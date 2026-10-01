using System;

namespace TwitterClone.Domain.Entities
{
    public class SystemNotification : Notification
    {
        public SystemNotification() : base("System")
        {
        }

        //public void AddMessage(string message)
        //{
        //    Message = message;
        //}

        public override string DescribeRecord()
        {
            return base.DescribeRecord();
        }

        // Implement the abstract member from Notification
        public override string GetMessage()
        {
            return $"System Notification ";
        }
    }
}