using CloudCustomers.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() =>
            new List<User>
            {
                    new User() {
                        Id = 1,
                        Name = "John",
                        Email = "John@example.com",
                        Address = new Address() {
                            Street = "123 Main st",
                            City = "Madison",
                            Zip = "53704"
                        },
                    },
                    new User() {
                        Id = 2,
                        Name = "Jane",
                        Email = "Jane@example.com",
                        Address = new Address() {
                            Street = "5555 Broadway ave",
                            City = "San Diego",
                            Zip = "92130"
                        },
                    },
                    new User() {
                        Id = 3,
                        Name = "Test User 3",
                        Email = "test.user.3@example.com",
                        Address = new Address() {
                            Street = "43 Maple ct",
                            City = "Somewhere",
                            Zip = "12345"
                        },
                    },
            };
    }
}
