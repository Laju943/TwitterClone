using System;

namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity,ILikeAble
    {
        private string _content;
        private Guid _userId;

        public Tweet(string content) : base(Guid.NewGuid())
        {
            _content = content;
        }

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

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();

            return $"{baseRecord}, UserId: {UserId}, Content: {Content}";
        }
        public bool CanBeLiked()
        {
            return true;
        }
    }
}