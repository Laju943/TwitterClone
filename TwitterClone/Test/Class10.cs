using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Domain.Entities;
namespace Test
{
    public class Class10
    {
        public void run()
        {
            var tweet = new Tweet("this is my first tweet!");
            ILikeAble likeabletweet = new Tweet("this is my another tweet!");
        
            Console.WriteLine(likeabletweet.CanBeLiked());

            var maxTweetLen = Tweet.MaxContentLenght;
        }
    }
}
