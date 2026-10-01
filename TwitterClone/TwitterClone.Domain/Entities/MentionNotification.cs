using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class MentionNotification : Notification
    {
        public MentionNotification(Guid mentionedByUserId) : base("Mention")
        {
            MentionedByUserId = mentionedByUserId;
        }
        public Guid MentionedByUserId { get; set; }
        //public void AddMessage(string message)
        //{
        //    Message = message;
        //}
        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, MentionedByUserId: {MentionedByUserId}";
        }

        // Implement the abstract member from Notification
        public override string GetMessage()
        {
            // Return the message stored in the base class. Adjust formatting if desired.
            return $"User with ID {MentionedByUserId} mentioned you in a post";
        }
    }
}
