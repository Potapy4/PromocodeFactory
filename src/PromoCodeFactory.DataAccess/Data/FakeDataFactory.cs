using System;
using System.Collections.Generic;
using System.Linq;
using PromoCodeFactory.Core.Domain.Administration;

namespace PromoCodeFactory.DataAccess.Data
{
    public static class FakeDataFactory
    {
        public static IEnumerable<Employee> Employees => new List<Employee>
        {
            new Employee
            {
                Id = Guid.Parse("451533d5-d8d5-4a11-9c7b-eb9f14e1a32f"),
                Email = "owner@mail.com",
                FirstName = "John",
                LastName = "Doe",
                Roles = new List<Role>
                {
                    Roles.FirstOrDefault(x => x.Name == "Admin")  
                },
                AppliedPromocodesCount = 5
            },
            new Employee
            {
                Id = Guid.Parse("f766e2bf-340a-46ea-bff3-f1700b435895"),
                Email = "andreev@mail.com",
                FirstName = "Alex",
                LastName = "Andreev",
                Roles = new List<Role>
                {
                    Roles.FirstOrDefault(x => x.Name == "PartnerManager")  
                },
                AppliedPromocodesCount = 10
            },
        };

        public static IEnumerable<Role> Roles => new List<Role>
        {
            new Role
            {
                Id = Guid.Parse("53729686-a368-4eeb-8bfa-cc69b6050d02"),
                Name = "Admin",
                Description = "Administrator",
            },
            new Role
            {
                Id = Guid.Parse("b0ae7aac-5493-45cd-ad16-87426a5e7665"),
                Name = "PartnerManager",
                Description = "Partner manager"
            }
        };
    }
}