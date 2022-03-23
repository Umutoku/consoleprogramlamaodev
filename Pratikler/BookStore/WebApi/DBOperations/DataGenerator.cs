using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApi.DBOperations;

namespace WebApi.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if(context.Books.Any())
                {
                    return;
                }
                context.Books.AddRange(
                    new Book{
                //ID=1,
                Title="Lean Startup",
                GenreId=1, // Personal Growth
                PageCount =200,
                PublisDate = new DateTime(2001,06,12)
            },
             new Book{
               // ID=2,
                Title="Hearlend",
                GenreId=2, // Science Fiction
                PageCount =250,
                PublisDate = new DateTime(2010,05,23)
            },
             new Book{
              //  ID=3,
                Title="Lean Startup",
                GenreId=1, // Personal Growth
                PageCount =540,
                PublisDate = new DateTime(2001,12,21)
            }
                );

                context.SaveChanges();
            }
        }
    }
}