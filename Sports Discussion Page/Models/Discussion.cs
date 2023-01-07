namespace Sports_Discussion_Page.Models
{
    public class Contribution
    {
        public int ContributionId { get; set; }
        public string Content { get; set; }
        public int Date { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }
        public int UserId { get; set; }

        // public int DiscussionId { get; set; }
    }
}