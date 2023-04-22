namespace LibraryMVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int YearOfProduction { get; set; }
        public Boolean isAvaible { get; set; }
    }
}
