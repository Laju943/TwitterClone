using TwitterClone.Domain.Entities;

namespace TwitterClone.API.Data
{
    public class TweetRepository
    {
        private readonly List<Tweet> _tweets = new();

        public IEnumerable<Tweet> GetAllTweets()
        {
            return _tweets;
        }

        public Tweet? GetTweetById(Guid id)
        {
           return _tweets.SingleOrDefault(t => t._id == id);
        }

        public Tweet AddTweet(Tweet tweet)
        {
            _tweets.Add(tweet);
            return tweet;
        }

        public Tweet? UpdateTweet(Guid id, string content)
        {
            var tweet = _tweets.SingleOrDefault(t => t._id == id);

            if (tweet == null)
                return null;

            tweet.Content = content;

            return tweet;
        }

        public bool DeleteTweet(Guid id)
        {
            var tweet = _tweets.SingleOrDefault(t => t._id == id);

            if (tweet == null)
                return false;

            _tweets.Remove(tweet);

            return true;
        }
    }
}