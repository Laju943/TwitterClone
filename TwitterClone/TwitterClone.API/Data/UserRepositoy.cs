using TwitterClone.Domain.Entities;

namespace TwitterClone.API.Data
{
    public class UserRepositoy
    {
        private List<User> _users {  get; set; }=new List<User>();
        public User AddUser(User user)
        {
           if(_users == null)
            {
                _users = new List<User>();
            }
            _users.Add(user);
            return user;
        }

        public User UpdateUser(User user)
        {
            _users.RemoveAll(u => u.Id == user.Id);
            _users.Add(user);
            return user;
        }

        public bool DeleteUser(User user) {
            return _users.Remove(user);
        }   
        public User ? GetUserById(Guid id)
        {
            return _users.SingleOrDefault(u => u.Id == id);
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }
        public User? GetUserByEmail(string email)
        {
            return _users.SingleOrDefault(u => u.Email == email);
        }
    }
}
