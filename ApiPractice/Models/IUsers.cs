namespace ApiPractice.Models
{
    public interface IUsers
    {
        User GetUser(int id);

        IEnumerable<User> GetUsers();

        void AddUser(User user);
        void UpdateUser(User user);

        void DeleteUser(int id);


    }
}
