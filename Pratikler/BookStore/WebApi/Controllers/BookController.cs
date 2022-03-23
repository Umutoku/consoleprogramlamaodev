using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using WebApi.DBOperations;
using WebApi.BookOperations.GetBooks;
using WebApi.BookOperations.CreateBook;
using static WebApi.BookOperations.CreateBook.CreateBookCommand;
using WebApi.BookOperations.GetBookDetailQuery;
using WebApi.BookOperations.UpdateBook;
using static WebApi.BookOperations.UpdateBook.UpdateBookCommand;
using WebApi.BookOperations.DeleteBook;

namespace WebApi.AddControllers{
    [ApiController]
    [Route("[controller]s")]
    public class BookController:ControllerBase
    {
        private readonly BookStoreDbContext  _context;

public BookController (BookStoreDbContext context)
{
    _context = context;
}

       /* private static List<Book> BookList = new List<Book>()
        {
            new Book{
                ID=1,
                Title="Lean Startup",
                GenreId=1, // Personal Growth
                PageCount =200,
                PublisDate = new DateTime(2001,06,12)
            },
             new Book{
                ID=2,
                Title="Hearlend",
                GenreId=2, // Science Fiction
                PageCount =250,
                PublisDate = new DateTime(2010,05,23)
            },
             new Book{
                ID=3,
                Title="Lean Startup",
                GenreId=1, // Personal Growth
                PageCount =540,
                PublisDate = new DateTime(2001,12,21)
            }
        };*/

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //var booklist = BookList.OrderBy(x=> x.ID).ToList<Book>();
            //return booklist;
            BookDetailViewModel result;
            try
            {
            GetBookDetailQuery query = new GetBookDetailQuery(_context);
            query.BookId = id;
            result = query.Handle();
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
            return Ok(result);


            //var book = _context.Books.Where(book=> book.ID==id).SingleOrDefault();
           // return book;
        }

        
        [HttpGet]
      public IActionResult GetBooks()
       {
            GetBooksQuery query = new GetBooksQuery(_context);
            var result = query.Handle();
            return Ok(result);
        }
       
        //Post
        [HttpPost]
        public IActionResult AddBook([FromBody]CreateBookModel NewBook)
        {
            CreateBookCommand command = new CreateBookCommand(_context);
            try
            {
            command.Model=NewBook;
            command.Handle();
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
            return Ok();
        }
        //Put
        [HttpPut("{id}")]

        public IActionResult UpdateBook(int id,[FromBody] UpdateBookModel updatedBook)
        {

            try
            {
                UpdateBookCommand command = new UpdateBookCommand(_context);
            command.BookId = id;
            command.Model = updatedBook;
            command.Handle();
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
            
            
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            try
            {
                DeleteBookCommand command = new DeleteBookCommand(_context);
            command.BookId = id;
            command.Handle();
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
            
            return Ok();
        }

    }
}