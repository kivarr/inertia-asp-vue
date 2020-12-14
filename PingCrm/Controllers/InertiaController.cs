using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using InertiaAdapter;
using InertiaTest.WebApp.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PingCrm.Data;
using PingCrm.Models;

namespace PingCrm.Controllers
{
    public class InertiaController : Controller
    {
        private readonly ApplicationUserStore _userStore;
        private readonly HttpContext _httpContext;
        public InertiaController(
            ApplicationUserStore userStore,
            IHttpContextAccessor httpContextAccessor
        )
        {
            _userStore = userStore;
            _httpContext = httpContextAccessor.HttpContext;
            
            GenerateShareModel();
        }

        internal void GenerateShareModel(IEnumerable<ErrorViewModel> errors = null,
            IEnumerable<ErrorViewModel> successes = null)
        {
            var user = _httpContext.User.Identity.IsAuthenticated
                ? _userStore.FindByNameAsync(_httpContext.User.Identity.Name)
                : null;

            user?.Wait();

            var userResult = user?.Result;
            
            Inertia.Share = new InertiaShareModel(){
                User = new {
                    first_name = userResult?.FirstName,
                    last_name = userResult?.LastName,
                    account = new
                    {
                        name = userResult?.Account?.Name
                    }
                },
                IsLogged = user != null,
                Errors = errors?.ToArray(),
                Successes = successes?.ToArray(),
            };
        }
    }

    public class InertiaShareModel
    {
        [JsonProperty("user")]
        public object User { get; set; }
        [JsonProperty("isLogged")]
        public bool IsLogged { get; set; }
        
        [JsonProperty("errors")]
        public ErrorViewModel[] Errors { get; set; }
        [JsonProperty("successes")]
        public ErrorViewModel[] Successes { get; set; }
    }

    public class ApplicationUserStore : UserStore<User>
    {
        public ApplicationUserStore(ApplicationDbContext context) : base(context)
        {
        }

        public override Task<User> FindByNameAsync(string name, CancellationToken token = default)
        {
            var user = Users.Include(u => u.Account)
                .FirstOrDefault(u => u.NormalizedUserName == name.ToUpper());
            
            return Users.Include(u => u.Account)
                .FirstOrDefaultAsync(u => u.NormalizedUserName == name.ToUpper(), cancellationToken: token);
        }
    }
}