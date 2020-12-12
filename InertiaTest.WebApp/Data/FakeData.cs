using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using Bogus.DataSets;
using Bogus.Extensions;
using InertiaTest.WebApp.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace WebApp.Data
{
    public static class FakeData
    {
        public static List<Account> Accounts = new List<Account>();
        public static List<User> Users = new List<User>();
        public static List<Organization> Organizations = new List<Organization>();
        public static List<Contact> Contacts = new List<Contact>();
        public static void Init()
        {
            var accountFaker = new Faker<Account>()
                .RuleFor(c => c.AccountId, f => Guid.NewGuid().ToString())
                .RuleFor(c => c.Name, f => f.Company.CompanyName());

            var accounts = accountFaker.Generate(1);
            Accounts.AddRange(accounts);
            var account = accounts.First();
            
            var hasher = new PasswordHasher<User>();
            
            var contactFaker = new Faker<Contact>()
                .RuleFor(c => c.ContactId, f => Guid.NewGuid().ToString())
                .RuleFor(c => c.FirstName, f => f.Name.FirstName())
                .RuleFor(c => c.LastName, f => f.Name.LastName())
                .RuleFor(c => c.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
                .RuleFor(c => c.Phone, f => f.Phone.PhoneNumber("#########"))
                .RuleFor(c => c.Address, f => f.Address.StreetAddress())
                .RuleFor(c => c.City, f => f.Address.City())
                .RuleFor(c => c.Region, f => f.Address.State())
                .RuleFor(c => c.Country, f => "US")
                .RuleFor(c => c.PostalCode, f => f.Address.ZipCode())
                .RuleFor(c => c.AccountId, f => account.AccountId);
            
            var organizationFaker = new Faker<Organization>()
                .RuleFor(c => c.OrganizationId, f => Guid.NewGuid().ToString())
                .RuleFor(c => c.Name, f => f.Company.CompanyName())
                .RuleFor(c => c.Email, (f, u) => f.Internet.ExampleEmail())
                .RuleFor(c => c.Phone, f => f.Phone.PhoneNumber("#########"))
                .RuleFor(c => c.Address, f => f.Address.StreetAddress())
                .RuleFor(c => c.City, f => f.Address.City())
                .RuleFor(c => c.Region, f => f.Address.State())
                .RuleFor(c => c.Country, f => "US")
                .RuleFor(c => c.PostalCode, f => f.Address.ZipCode())
                .RuleFor(c => c.AccountId, f => account.AccountId)
                .RuleFor(c => c.Contacts, (f, u) =>
                {
                    contactFaker.RuleFor(c => c.OrganizationId, _ => u.OrganizationId);
                    var contacts = contactFaker.GenerateBetween(5, 15);
                    Contacts.AddRange(contacts);
                    return null;
                });

            var userFaker = new Faker<User>()
                .RuleFor(c => c.Id, f => Guid.NewGuid().ToString())
                .RuleFor(c => c.FirstName, f => f.Name.FirstName())
                .RuleFor(c => c.LastName, f => f.Name.LastName())
                .RuleFor(c => c.Email, (f, u) => f.Internet.ExampleEmail(u.FirstName, u.LastName).ToLower())
                .RuleFor(c => c.NormalizedEmail, (f, u) => u.Email.ToUpper())
                .RuleFor(c => c.UserName, (f, u) => u.Email)
                .RuleFor(c => c.NormalizedUserName, (f, u) => u.NormalizedEmail)
                .RuleFor(c => c.EmailConfirmed, f => true)
                .RuleFor(c => c.AccountId, f => account.AccountId)
                .RuleFor(c => c.PasswordHash, (f,u) => hasher.HashPassword(u, "secret"));

            var users = userFaker.Generate(5);
            var organizations = organizationFaker.Generate(10);
            Users.AddRange(users);
            Organizations.AddRange(organizations);
        }
    }
}