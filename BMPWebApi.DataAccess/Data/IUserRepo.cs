using System.Collections.Generic;
using BPMWebApi.Library.Models;

namespace BPMWebApi.Data {
    public interface IUserRepo {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
    }
}
