using System.Collections.Generic;
using System.Linq;
using WebApi.DBOperations;
using WebApi.Common;
using System;

namespace WebApi.BookOperations.DeleteBook
{
    public class DeleteBookCommand
    {
        

        private readonly BookStoreDbContext _dbContext;
        public int BookId { get; set; }

        public DeleteBookCommand(BookStoreDbContext dbContext)
        {
            _dbContext=dbContext;
        }

        public void Handle()
        {
            
             var book = _dbContext.Books.SingleOrDefault(x=>x.ID==BookId);
            if(book is null)
                throw new InvalidOperationException("Silinecek kitap yok");

            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
        }
    }
}