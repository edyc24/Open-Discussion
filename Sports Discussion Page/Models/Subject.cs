namespace Sports_Discussion_Page.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int FollowersCount { get; set; }
        public int DiscussionsCount { get; set; }

        // lista de discutii
        public List<Discussion> Discussions { get; set; }
    }
}