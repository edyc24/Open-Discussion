namespace Sports_Discussion_Page.Models
{
    public class Discussion
    {
        public int DiscussionId { get; set; }
        public string Title { get; set; }
        public DateTime PostTime { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }
        public int Views { get; set; }
        public int UserId { get; set; }

        // lista de contributii
        public List<Contribution> Contributions { get; set; }
    }
}