namespace TwitterClone.API.Dtos
{
    public class TweetDto
    {
        public Guid Id { get; set; }
        public string? Content { get; set; } 
        public Guid UserId { get; set; } 

    }
}
