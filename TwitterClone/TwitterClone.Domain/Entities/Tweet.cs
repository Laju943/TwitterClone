namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {
        private Guid _id;
        private string _content;
        private Guid _userId;
        private DateTime _createdAt;
        private DateTime _updatedAt;

        public Guid Id { get { return _id; } }
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; }
        }
        public DateTime UpdatedAt
        {
            get { return _updatedAt; }
            set { _updatedAt = value; }
        }
    }
}
