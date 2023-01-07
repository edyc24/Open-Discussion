namespace Sports_Discussion_Page.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        // lista de subiecte
        public List<Subject> Subjects { get; set; }
    }
}