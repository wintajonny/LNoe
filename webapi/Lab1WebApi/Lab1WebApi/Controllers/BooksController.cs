using Lab1WebApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Lab1WebApi.Models.Books;
using Microsoft.AspNetCore.Http;

namespace Lab1WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksService _booksService;

        public BooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpGet]
        public async Task<IEnumerable<Book>> GetBooks()
        {
            var result = await _booksService.GetBooksAsync();
            return result;
        }

        [HttpGet("{id}", Name = "GetBookById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<Book>> GetBookById(int id)
        {
            var book = await _booksService.GetBookByIdAsync(id);
            if (book is null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            if (book is null) return BadRequest();

            var newBook = await _booksService.AddBookAsync(book);
            return CreatedAtRoute("GetBookById", new { id = newBook.BookId }, newBook);

        }




    }
}
