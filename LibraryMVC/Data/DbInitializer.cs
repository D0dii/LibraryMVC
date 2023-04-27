namespace LibraryMVC.Data
{
    public class DbInitializer
    {
        private readonly LibraryMVCContext _dbContext;
        public DbInitializer(LibraryMVCContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if(await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.Books.Any())
                {
                    var Book1 = new Models.Book()
                    {
                        Title = "Dziady",
                        Author = "Adam Mickiewicz",
                        YearOfProduction = 1988
                    };
                    var Book2 = new Models.Book()
                    {
                        Title = "Outsider",
                        Author = "Stephen King",
                        YearOfProduction = 2018
                    };
                    var Book3 = new Models.Book()
                    {
                        Title = "Krzyzacy",
                        Author = "Henryk Sienkiewicz",
                        YearOfProduction = 1970
                    };
                    var Book4 = new Models.Book()
                    {
                        Title = "Lalka",
                        Author = "Boleslaw Prus",
                        YearOfProduction = 1990
                    };
                    _dbContext.Add(Book1);
                    _dbContext.Add(Book2);
                    _dbContext.Add(Book3);
                    _dbContext.Add(Book4);
                    _dbContext.SaveChanges();
                }
            }
        }
    }
}
