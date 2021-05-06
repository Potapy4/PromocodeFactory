using System;
using System.Collections.Generic;
using Bogus;
using PromoCodeFactory.Core.Domain.Administration;

namespace PromoCodeFactory.DataAccess.Data
{
    public static class FakeDataFactory
    {
        public static IEnumerable<Employee> Employees => new Faker<Employee>()
            .RuleFor(e => e.Id, Guid.NewGuid())
            .RuleFor(e => e.FirstName, (f) => f.Name.FirstName())
            .RuleFor(e => e.LastName, (f) => f.Name.LastName())
            .RuleFor(e => e.Email, (f, e) => f.Internet.Email(e.FirstName, e.LastName))
            .RuleFor(e => e.AppliedPromocodesCount, f => f.Random.Number(1, 10))
            .RuleFor(e => e.Roles, f => new List<Role> { f.PickRandom(Roles) })
            .Generate(10);

        public static IEnumerable<Role> Roles => new List<Role>
        {
            new()
            {
                Id = Guid.Parse("53729686-a368-4eeb-8bfa-cc69b6050d02"),
                Name = "Admin",
                Description = "Administrator",
            },
            new()
            {
                Id = Guid.Parse("b0ae7aac-5493-45cd-ad16-87426a5e7665"),
                Name = "PartnerManager",
                Description = "Partner manager"
            }
        };
    }
}