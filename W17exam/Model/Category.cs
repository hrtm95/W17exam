namespace W17exam.Model
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
