using Microsoft.AspNetCore.Mvc;

namespace Web_API;

public class BooksController : Controller
{

    private static List<Book> books = new List<Book>
    {
        new Book { Id = 1, Title = "Cracking the Coding Interview", Author = "Gayle McDowell", Description = "189 Programming Questions and Solutions"},
        new Book { Id = 2, Title = "Cracking the Coding Interview 2", Author = "Gayle McDowell", Description = "190 Programming Questions and Solutions"}
        
    };

    // GET (READ)
    [HttpGet("{Id}")]
    public IActionResult GetBook(int Id)
    {
        var book = books.FirstOrDefault(b => b.Id == Id);
        if (book == null)
        {
            return NotFound();
        }

        return Ok(book);
    }

    // POST (CREATE)
    [HttpPost]
    public IActionResult CreateBook([FromBody] Book newBook)
    {
        newBook.Id = books.Count + 1;
        books.Add(newBook);
        return CreatedAtAction(nameof(GetBook), new { id = newBook.Id }, newBook);
    }
    
    // PUT (UPDATE)
    [HttpPut("{id}")]
    public IActionResult UpdateBook(int id, [FromBody] Book updatedBook)
    {
        var book = books.FirstOrDefault(b => b.Id == id);
        if (book == null)
        {
            return NotFound();
        }
        book.Title = updatedBook.Title;
        book.Author = updatedBook.Author;
        book.Description = updatedBook.Description;

        return NoContent();
    }
    
    // DELETE (DELETE)
    [HttpDelete("{id}")]
    public IActionResult DeleteBook(int id)
    {
        var book = books.FirstOrDefault(b => b.Id == id);
        if (book == null)
        {
            return NotFound();
        }
        books.Remove(book);
        return NoContent();
    }
    
    
    
}