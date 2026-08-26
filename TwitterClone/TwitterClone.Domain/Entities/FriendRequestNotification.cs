using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class FriendRequestNotification:Notification
    {
        public FriendRequestNotification(Guid reqId) : base("FriendRequest")
        {
            ReqId = reqId;
        }
        public Guid ReqId { get; set; }
        public void AddMessage(string message)
        {
            Message = message;
        }
        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, RequestedByUserId: {ReqId}";
        }
    }
}
