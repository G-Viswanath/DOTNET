using Microsoft.AspNetCore.Mvc;
using LibraryAPI_WithDummyData.Models;

namespace LibraryAPI_WithDummyData.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase {

        private static List<Book> _books = new(){
            new Book{Id=1,Title="Harry Potter",Author="J.K. Rowling",ISBN="HP001",Genre="Fantasy",Quantity=10},
            new Book{Id=2,Title="The Hobbit",Author="Tolkien",ISBN="HB002",Genre="Fantasy",Quantity=5}
        };

        [HttpGet]
        public IActionResult GetAll() => Ok(_books);
    }
}