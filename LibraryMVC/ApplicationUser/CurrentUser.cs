namespace LibraryMVC.ApplicationUser
{
    public class CurrentUser
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public CurrentUser(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
