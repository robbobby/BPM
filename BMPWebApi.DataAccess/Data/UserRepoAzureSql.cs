using System;
using System.Collections.Generic;
using System.Linq;
using BPMWebApi.Data;
using BPMWebApi.Library.Models;

namespace BMPWebApi.DataAccess.Data {
    public class UserRepoAzureSql : IUserRepo {

        private readonly UserContext _context;
        
        public UserRepoAzureSql(UserContext context) {
            _context = context;
        }
        
        public IEnumerable<User> GetAllUsers() {
            return _context.Users.ToList();
        }
        public User GetUserById(int id) {
            return _context.Users.FirstOrDefault(user => user.Id == id);
        }
        public void CreateUser(User user) {
            if (user == null) 
                throw new ArgumentNullException(nameof(user));
            _context.Add(user);
        }
        public bool SaveChanges() {
            return (_context.SaveChanges()) >= 0;
        }
    }
}
