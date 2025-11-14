using Microsoft.AspNetCore.Mvc;
using LibraryAPI_WithDummyData.Models;

namespace LibraryAPI_WithDummyData.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class BorrowersController : ControllerBase {

        private static List<Borrower> _borrowers = new(){
            new Borrower{Id=1,Name="John Doe",Email="john@example.com",MembershipId="M001"},
            new Borrower{Id=2,Name="Alice",Email="alice@example.com",MembershipId="M002"}
        };

        [HttpGet]
        public IActionResult GetAll() => Ok(_borrowers);
    }
}