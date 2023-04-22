using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryMVC.Models;

namespace LibraryMVC.Data
{
    public class LibraryMVCContext : DbContext
    {
        public LibraryMVCContext (DbContextOptions<LibraryMVCContext> options)
            : base(options)
        {
        }

        public DbSet<LibraryMVC.Models.Book> Book { get; set; } = default!;
    }
}
