namespace WebApplication65.Models
{
    public class UserService: IUserService
    {
        private readonly IUserRespository _userRespository;

        public UserService(IUserRespository userRespository)
        {
            _userRespository = userRespository;
        }

        public void AddUser(User user)
        {
            _userRespository.AddUser(user);
        }

        public void DeleteUser(int userId)
        {
            _userRespository.DeleteUser(userId);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRespository.GetAllUsers();  
        }

        public User GetUserById(int userId)
        {
            return _userRespository.GetUserById(userId);
        }

        public void UpdateUser(User user)
        {
            _userRespository.UpdateUser(user);
        }
    }
}
