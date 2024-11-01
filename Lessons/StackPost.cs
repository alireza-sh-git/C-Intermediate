using System.Diagnostics.Contracts;

namespace Lessons
{
    public class StackPost
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int Vote { get; private set; }

        public StackPost(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.Vote = 0;
        }

        public void Upvote()
        {
            Vote += 1;
        }
        public void Downvote()
        {
            Vote -= 1;
        }
    }
}