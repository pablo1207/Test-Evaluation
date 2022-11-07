using Application.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Persistence
{
    public class UsersMoq : IUsersMoq
    {
        public IEnumerable<User> Find(Expression<Func<User, bool>> expression)
        {
            return Users().AsQueryable().Where<User>(expression);
        }

        public IEnumerable<User> Get()
        {
            return Users();
        }

        private List<User> Users()
        {
            return new List<User>()
            {
                new User
                {
                    Id = Guid.Parse("00000000-04bb-0000-b85c-000000000000"),
                    Name = "Juan",
                    LastName = "Reyes",
                    Email = "juan.reyes@yopmail.com",
                    PhoneNumber = "5500000010",
                    Departament = "DHO"
                },
                new User
                {
                    Id = Guid.Parse("00000000-04bb-0000-b85c-000000000001"),
                    Name = "Pablo",
                    LastName = "Hidalgo",
                    Email = "juan.reyes@yopmail.com",
                    PhoneNumber = "5500000010",
                    Departament = "DHO"
                },
                new User
                {
                    Id = Guid.Parse("00000000-04bb-0000-b85c-000000000002"),
                    Name = "Emir",
                    LastName = "Lagunas",
                    Email = "juan.reyes@yopmail.com",
                    PhoneNumber = "5500000010",
                    Departament = "Desarrollo"
                },
                new User
                {
                    Id = Guid.Parse("00000000-04bb-0000-b85c-000000000003"),
                    Name = "Jose",
                    LastName = "Cruz",
                    Email = "juan.reyes@yopmail.com",
                    PhoneNumber = "5500000010",
                    Departament = "Desarrollo"
                },
                new User
                {
                    Id = Guid.Parse("00000000-04bb-0000-b85c-000000000004"),
                    Name = "Jose",
                    LastName = "Morelos",
                    Email = "juan.reyes@yopmail.com",
                    PhoneNumber = "5500000010",
                    Departament = "Desarrollo"
                },
                new User
                {
                    Id = Guid.Parse("00000000-04bb-0000-b85c-000000000005"),
                    Name = "Ana",
                    LastName = "Rios",
                    Email = "juan.reyes@yopmail.com",
                    PhoneNumber = "5500000010",
                    Departament = "Nóminas"
                },
                new User
                {
                    Id = Guid.Parse("00000000-04bb-0000-b85c-000000000006"),
                    Name = "Cecilia",
                    LastName = "Adame",
                    Email = "juan.reyes@yopmail.com",
                    PhoneNumber = "5500000010",
                    Departament = "Legal"
                },
                new User
                {
                    Id = Guid.Parse("00000000-04bb-0000-b85c-000000000007"),
                    Name = "Maria",
                    LastName = "Tellez",
                    Email = "juan.reyes@yopmail.com",
                    PhoneNumber = "5500000010",
                    Departament = "Diseño"
                }
            };
        }
    }
}
