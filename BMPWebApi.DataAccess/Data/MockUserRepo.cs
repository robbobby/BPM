using System.Collections.Generic;
using BPMWebApi.Library.Models;

namespace BPMWebApi.Data {
    public class MockUserRepo : IUserRepo {
        public IEnumerable<User> GetAllUsers() {
            return new[] {
                new User { Id = 1, EmailAddress = "john@hotmail.com", FirstName = "John", LastName = "Smith" },
                new User { Id = 2, EmailAddress = "lacey@hotmail.com", FirstName = "Lacey", LastName = "Jeffords" },
                new User { Id = 3, EmailAddress = "lina@hotmail.com", FirstName = "Lina", LastName = "Biel" }
            };
        }
        
        public User GetUserById(int id) {
            return new User { Id = 3, EmailAddress = "lina@hotmail.com", FirstName = "Lina", LastName = "Biel" };
        }
    }
}
