

namespace TwitterClone.Domain.Entities
{
    public class User
    {
        private Guid _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        
        public Guid ID
        {
            get { return _id; }
        }

        public string FirstName {
            get { return _firstName; } 
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    }
}
