using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model31.Data;
using Microsoft.Extensions.DependencyInjection;


namespace Model31.Models
{
    public class Seed
    {
        public static void Initialize(IServiceProvider serviceprovider)
        {
            using (var context= new BookContext(serviceprovider.GetRequiredService<DbContextOptions<BookContext>>()))
            {   
                if(context.Books.Any())
                {
                    return;
                }
                context.Books.AddRange(
                    new Book
                    {
                        Btitle = "Indian Short Stories",
                        Category = "Fiction",
                        price = 716.00,
                        AuthorName = "Narayan",
                        Publisher = "Pengwin",
                        ReleaseDate = Convert.ToDateTime("10-09-2014")
                    },

                     new Book
                     {
                         Btitle = "The Secret",
                         Category = "Motivation",
                         price = 550.00,
                         AuthorName = "Ali",
                         Publisher = "Shinchan",
                         ReleaseDate = Convert.ToDateTime("10-09-2012")
                     },

                      new Book
                      {
                          Btitle = "1000 stories",
                          Category = "Comedy",
                          price = 900.00,
                          AuthorName = "Narayana",
                          Publisher = "Pandit",
                          ReleaseDate = Convert.ToDateTime("11-04-2011")
                      }
                      



                    );
                context.SaveChanges();
            }
        }

    }
}
