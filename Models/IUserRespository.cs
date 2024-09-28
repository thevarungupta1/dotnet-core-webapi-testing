namespace WebApplication65.Models
{
    public interface IUserRespository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int userId);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int userId);

    }
}
