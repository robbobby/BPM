using System.Collections.Generic;
using BPMDesktopUi.Models;
namespace BPMDesktopUi.Services {
    public class MockUserDb {
        public static IEnumerable<User> GetUsers() => new[] {
            new User() {
                FirstName = "Robert",
                LastName = "Hollingworth",
                EmailAddress = "r.hollingworht@hotmail.com"
            },
            new User() {
                FirstName = "Lina",
                LastName = "Biel",
                EmailAddress = "l.biel@hotmail.com"
            },
            new User() {
                FirstName = "Bob",
                LastName = "George",
                EmailAddress = "b.george@hotmail.com"
            }
        };
    }
}
