

namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity
    {
        private string _firstName;
        private string _username;
        private string _email;
        private string _lastName;
        public User() : base(Guid.NewGuid())
        {

        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    }
}
