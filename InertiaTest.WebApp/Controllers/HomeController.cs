using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using InertiaAdapter;
using InertiaTest.WebApp.Data.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WebApp.Data;
using WebApp.Models;
using X.PagedList;

namespace WebApp.Controllers
{
    public class HomeController : InertiaController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly ApplicationUserStore _userStore;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, 
            UserManager<User> userManager,
            IHttpContextAccessor httpContextAccessor, SignInManager<User> signInManager, ApplicationUserStore userStore, ApplicationDbContext context) 
            : base(userStore, httpContextAccessor)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            _userStore = userStore;
            _context = context;
        }

        [Authorize]
        public IActionResult Index()
        {
            //your js component file name.
            var componentName = "Welcome";
            //return whatever you want.
            var data = new { Id = 1 };
            //return Inertia Result.
            return Inertia.Render(componentName, data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
        
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            return Inertia.Render("Auth/Login", new
            {
                returnUrl
            });
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody]LoginViewModel model, string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe ?? false,
                lockoutOnFailure: true);
            
            if (result.Succeeded)
            {
                return LocalRedirect(returnUrl);
            }
            
            return Inertia.Render("Auth/Login", new
            {
                returnUrl
            });
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Orgs(int? page, string search = null, string trashed = "with")
        {
            var currentPage = page ?? 1;
            var source = _context.Organizations.IgnoreQueryFilters();

            if (!string.IsNullOrEmpty(search))
            {
                source = source.Where(o =>
                    EF.Functions.Like(o.Name, $"%{search}%") ||
                    EF.Functions.Like(o.City, $"%{search}%") ||
                    EF.Functions.Like(o.Phone, $"%{search}%")
                );
            }

            if (trashed == "only")
                source = source.Where(o => o.DeletedAt != null);

            var orgs = await source
                .Select(o => new
                {
                    id = o.OrganizationId,
                    name = o.Name,
                    phone = o.Phone,
                    city = o.City,
                    deleted_at = o.DeletedAt
                })
                .ToPagedListAsync(currentPage, 8);

            var ob = new
            {
                organizations = new
                {
                    data = orgs.ToList(),
                    links = new List<object>()
                    {
                        new
                        {
                            url = orgs.IsFirstPage ? null : $"{Url.ActionWithPaginationQuery("Orgs", Request.Query, orgs.PageNumber - 1)}",
                            active = orgs.IsFirstPage,
                            label = "Previous"
                        }
                    }
                },
                filters = new
                {
                    trashed,
                    search,
                    page = currentPage
                }
            };

            for (int i = 1; i <= orgs.PageCount; i++)
            {
                ob.organizations.links.Add(new
                {
                    url = $"{Url.ActionWithPaginationQuery("Orgs", Request.Query, i)}",
                    active = orgs.PageNumber == i,
                    label = i.ToString()
                });
            }

            ob.organizations.links.Add(new
            {
                url = orgs.IsLastPage ? null : $"{Url.ActionWithPaginationQuery("Orgs", Request.Query, orgs.PageNumber + 1)}",
                active = orgs.IsLastPage,
                label = "Next"
            });
            
            return Inertia.Render("Organizations/Index", ob);
        }

        [Authorize]
        [HttpGet]
        [Route("Home/Orgs/{id}/Edit")]
        public async Task<IActionResult> EditOrg(string id)
        {
            var org = _context.Organizations.IgnoreQueryFilters()
                .Select(o => new
                {
                    id = o.OrganizationId,
                    name = o.Name,
                    email = o.Email,
                    phone = o.Phone,
                    address = o.Address,
                    city = o.City,
                    region = o.Region,
                    country = o.Country,
                    postal_code = o.PostalCode,
                    deleted_at = o.DeletedAt,
                    contacts = o.Contacts.Select(c => new
                    {
                        id = c.ContactId,
                        name = c.FirstName + " " + c.LastName,
                        city = c.City,
                        phone = c.Phone,
                        deleted_at = c.DeletedAt
                    }).ToArray()
                })
                .FirstOrDefault(o => o.id == id);

            var vm = new
            {
                organization = org,
                errors = TempData.ContainsKey("errors") ? TempData["errors"] : new {}
            };

            return Inertia.Render("Organizations/Edit", vm);
        }

        [Authorize]
        [HttpPut]
        [Route("Home/Orgs/{id}")]
        public async Task<IActionResult> EditOrg([FromBody]OrganizationViewModel organization, string id)
        {
            var org = _context.Organizations.FirstOrDefault(o => o.OrganizationId == id);
            if (org == null || !ModelState.IsValid)
            {
                var modelState = ModelState
                    .Select(p => new { key = p.Key, errors = p.Value.Errors.Select(e => e.ErrorMessage).FirstOrDefault() })
                    .ToDictionary(kv => kv.key, kv => kv.errors);
                TempData.Add("errors", modelState);
                return RedirectToAction("EditOrg", new {id});
            }

            _context.Attach(org);
            org.Name = organization.Name;
            org.Email = organization.Email;
            org.Phone = organization.Phone;
            org.Address = organization.Address;
            org.City = organization.City;
            org.Region = organization.Region;
            org.Country = organization.Country;
            org.PostalCode = organization.PostalCode;
            await _context.SaveChangesAsync();

            return RedirectToAction("Orgs");
        }
    }

    public class OrganizationViewModel
    {
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }
    }

    public static class UrlExtensions
    {
        public static string ActionWithPaginationQuery(this IUrlHelper helper, string action, IQueryCollection query, int page)
        {
            if (helper == null)
            {
                throw new ArgumentNullException(nameof(helper));
            }
            
            var qs = QueryString.Empty;
            foreach (var item in query)
            {
                if (item.Key == "page")
                    qs = qs.Add(item.Key, page.ToString());
                else if (item.Key != "remember")
                    qs = qs.Add(item.Key, item.Value);
            }

            if (!query.ContainsKey("page"))
                qs = qs.Add("page", page.ToString());

            return
                $"{helper.Action(action, controller: null, values: null, protocol: null, host: null, fragment: null)}{qs.ToString()}";
        }
    }
    
    public class LoginViewModel : BaseViewModel
    {
        [Required]
        [EmailAddress]
        [JsonProperty("email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [JsonProperty("password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        [JsonProperty("remember")]
        public bool? RememberMe { get; set; }
    }

    public class BaseViewModel
    {
    }
}