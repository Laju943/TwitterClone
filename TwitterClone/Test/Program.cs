// See https://aka.ms/new-console-template for more information
using TwitterClone.Domain.Entities;

//Console.WriteLine("Hello, World!");
//var notification = new Notification("comment");
//var mssg=notification.GetMessage();
//Console.WriteLine(mssg);

//var likeNotification = new LikeNotification(Guid.NewGuid());
//Console.WriteLine(likeNotification.GetMessage());
//var mentionNotification = new MentionNotification(Guid.NewGuid());
//Console.WriteLine(mentionNotification.GetMessage());

//task2 emon kichu dorkar zeno mention class obbossoi GetMessage method override kore

var notification = new List<Notification>()
{
    new LikeNotification(Guid.NewGuid()),
    new MentionNotification(Guid.NewGuid()),
    new CommentNotification(Guid.NewGuid()),
    new SystemNotification()
};

foreach (var notif in notification)
{
    Console.WriteLine($"Notification Type: {notif.Type}, Message: {notif.GetMessage()}");
}