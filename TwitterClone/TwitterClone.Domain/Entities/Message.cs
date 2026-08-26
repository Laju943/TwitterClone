namespace TwitterClone.Domain.Entities
{
    public class Message:BaseEntity
    {

        public Message() : base(Guid.NewGuid())
        {

        }
        private Guid _senderId;
        private Guid _receiverId;
        private string _content = string.Empty;
        private DateTime _sentAt;
        private bool _isRead;
      
        public Guid SenderId
        {
            get { return _senderId; }
            set { _senderId = value; }
        }
        public DateTime SentAt
        {
            get { return _sentAt; }
            set { _sentAt = value; }
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
        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, SenderId: {SenderId}, ReceiverId: {ReceiverId}, Content: {Content}, SentAt: {SentAt}, IsRead: {IsRead}";
        }
    }
}
