using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("Testing", "Just testing this program!");
            post.upVote();
            post.upVote();
            post.upVote();
            post.upVote();
            post.downVote();
            Console.WriteLine(post.currentVoteValue());

        }
    }
}
