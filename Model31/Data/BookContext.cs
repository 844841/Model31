using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model31.Models;
using Microsoft.EntityFrameworkCore;

namespace Model31.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
