using System.Collections.Generic;
using System.Linq;
using Shop.Models;

namespace Shop.Repositories
{
    public class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>
            {
                new User { Id = 1, UserName = "batman", Password = "12345", Role = "manager" },
                new User { Id = 1, UserName = "robin", Password = "12345", Role = "employee" }
            };

            return users.FirstOrDefault(u => u.UserName == username && u.Password == password);
        }
    }
}