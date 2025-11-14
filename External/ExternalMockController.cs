using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI_WithDummyData.External {
    [ApiController]
    [Route("api/external/mock")]
    public class ExternalMockController : ControllerBase {

        [HttpGet("{isbn}")]
        public IActionResult MockBook(string isbn){
            return Ok(new { isbn, title="External Dummy Title", author="External Dummy Author" });
        }
    }
}