using Microsoft.AspNetCore.Mvc;

using MyFirstAPI.Models;
using MyFirstAPI.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstAPI.Controllers
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

        // GET: api/<BooksController>
        [HttpGet]
        public async Task<IEnumerable<Book>> GetBooks()
        {
            var result = await _booksService.GetBooksAsync();
            return result;
        }

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<BooksController>/5
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type=typeof(Book))]
        [HttpGet("{id}", Name ="GetBookById")]
        public async Task<ActionResult<Book>> GetBookById(int id)
        {
            var book = await _booksService.GetBookByIdAsync(id);
            if (book is null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        // POST api/<BooksController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            if (book is null) return BadRequest();

            var newBook = await _booksService.AddBookAsync(book);
            return CreatedAtRoute("GetBookById", new { id = newBook.BookId }, newBook);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
