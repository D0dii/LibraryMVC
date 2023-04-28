using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LibraryMVC.Data
{
    public class LibraryMVCContext : IdentityDbContext
    {
        public LibraryMVCContext (DbContextOptions<LibraryMVCContext> options)
            : base(options)
        {
        }

        public DbSet<LibraryMVC.Models.Book> Books { get; set; } = default!;
        public DbSet<LibraryMVC.Models.BookRent> BookRents { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
