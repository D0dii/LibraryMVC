namespace LibraryMVC.Models
{
    public class BookRent
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Fee { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Book Book { get; set; }

        public int BookId { get; set; }
        public int countFee()
        {
            DateTime today = DateTime.Now;
            if (today>EndDate)
            {
                return (EndDate - today).Days;
            }
            return -1;
        }

    }
}
