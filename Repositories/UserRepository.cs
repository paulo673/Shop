namespace Shop.Repositories
{
    public class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();

            users.add(new User { Id = 1, Name = "batman", Password = "12345", Role = "admin"});
            users.add(new User { Id = 1, Name = "robin", Password = "12345", Role = "employe"});

            return users.where(u => u.Username == username && u.Password == password).FirstOrDefault();
        }
    }
}