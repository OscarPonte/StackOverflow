using System;

namespace StackOverflow
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        private DateTime _dateCreated;
        private int _voteValue;

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            _dateCreated = DateTime.Now;
            _voteValue = 0;
        }

        public void upVote()
        {
            _voteValue++;
        }

        public void downVote()
        {
            _voteValue--;
        }

        public int currentVoteValue()
        {
            return _voteValue;
        }

    }
}