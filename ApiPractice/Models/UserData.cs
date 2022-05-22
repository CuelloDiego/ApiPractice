namespace ApiPractice.Models
{
    public class UserData : IUsers
    {
        private List<User> users = new()
        {
            new User() { Id = 1, Name = "Lara", Age = 20 },
            new User() { Id = 2, Name = "Jorge", Age = 23 },
            new User() { Id = 3, Name = "Federico", Age = 29 }

        };



        public void AddUser(User user)
        {

            users.Add(user);
        }

        public void DeleteUser(int id)
        {

            foreach (var item in users.ToList())
            {
                if (item.Id == id) { users.Remove(item); }

            }

        }

        public User GetUser(int id)
        {
            return users.FirstOrDefault(x => x.Id == id);

        }

        public IEnumerable<User> GetUsers()
        {
            return users;
        }

        public void UpdateUser(User user)
        {
            var foundUser = users.FirstOrDefault(x => x.Id == user.Id);
            if (foundUser is not null)
            {
                foundUser.Name = user.Name;
                foundUser.Age = user.Age;
            }





        }
    }
}
