namespace TwitterClone.Domain.Entities
{
    public abstract class Notification:BaseEntity
    {
        private Guid _userId;
        private string _type= string.Empty;
        private string _message= string.Empty;
        private bool _isRead;

        public Notification(string type):base(Guid.NewGuid())
        {
            _type = type;
        }

        
        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        protected string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }

        protected string message
        {
            get { return _message; }
            set { _message = value; }
        }
        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, UserId: {UserId}, Type: {Type}, Message: {Message}, IsRead: {IsRead}";
        }
        public abstract string GetMessage();
    }
}
