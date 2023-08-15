namespace W17exam.Model
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
