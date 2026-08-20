namespace TwitterClone.Domain.Entities
{
    public class Message
    {
        private Guid _id;
        private Guid _senderId;
        private Guid _receiverId;
        private string _content = string.Empty;
        private bool _isRead;
        private DateTime _createdAt;

        public Guid ID
        {
            get { return _id; }
        }

        public Guid SenderId
        {
            get { return _senderId; }
            set { _senderId = value; }
        }

        public Guid ReceiverId
        {
            get { return _receiverId; }
            set { _receiverId = value; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; }
        }
    }
}
