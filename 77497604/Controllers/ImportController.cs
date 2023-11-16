using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StackOverflow_77497604.Controllers;

[ApiController]
[Route("api/import/v1")]
public class ImportController : ControllerBase {
    [AllowAnonymous]
    [HttpPost("{id1}/{id2}/{id3?}")]
    public ActionResult Test(string id1, string id2, string? id3 = "000") {
        return Ok(new { id1, id2, id3 });
    }
}