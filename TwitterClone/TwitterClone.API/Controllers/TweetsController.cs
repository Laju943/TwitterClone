using Microsoft.AspNetCore.Mvc;
using TwitterClone.API.Data;
using TwitterClone.API.Dtos;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TweetsController : ControllerBase
    {
        private readonly TweetRepository _tweetRepository;

        public TweetsController(TweetRepository tweetRepository)
        {
            _tweetRepository = tweetRepository;
        }

        // GET /api/tweets
        [HttpGet]
        public IActionResult GetTweets()
        {
            var tweets = _tweetRepository.GetAllTweets();

            return Ok(tweets);
        }

        // GET /api/tweets/{id}
        [HttpGet("{id}")]
        public IActionResult GetTweetById([FromRoute] Guid id)
        {
            var tweet = _tweetRepository.GetTweetById(id);

            if (tweet == null)
                return NotFound("Tweet not found.");

            return Ok(tweet);
        }

        // POST /api/tweets
        [HttpPost]
        public IActionResult CreateTweet([FromBody] CreateTweetDto createTweetDto)
        {
            if (string.IsNullOrWhiteSpace(createTweetDto.Content))
                return BadRequest("Content is required.");

            var tweet = new Tweet(createTweetDto.Content)
            {
                UserId = Guid.NewGuid()
            };

            var createdTweet = _tweetRepository.AddTweet(tweet);

            return Ok(createdTweet);
        }

        // PUT /api/tweets/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateTweet(
    [FromRoute] Guid id,
    [FromBody] UpdateTweetDto updateTweetDto)
        {
            if (string.IsNullOrWhiteSpace(updateTweetDto.Content))
                return BadRequest("Content is required.");

            var tweet = _tweetRepository.UpdateTweet(
                id,
                updateTweetDto.Content
            );

            if (tweet == null)
                return NotFound("Tweet not found.");

            return Ok(tweet);
        }

        // DELETE /api/tweets/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteTweet([FromRoute] Guid id)
        {
            var deleted = _tweetRepository.DeleteTweet(id);

            if (!deleted)
                return NotFound("Tweet not found.");

            return Ok("Tweet deleted successfully.");
        }
    }
}