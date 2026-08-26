using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class LikeNotification : Notification
    {
        public Guid LikeByUserId { get; set; }
        public LikeNotification(Guid likeByUserId): base("Like")
        {
           LikeByUserId = likeByUserId;
        }

        public void Addmessage(string message)
        {
            Message = message;
        }
        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, LikeByUserId: {LikeByUserId}";
        }
    }
}
