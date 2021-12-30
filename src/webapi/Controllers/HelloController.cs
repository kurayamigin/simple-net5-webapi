using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    [ApiController]
    [Route("/")] // Https://localhost:80/
    public class HelloController : ControllerBase
    {
        
        [HttpGet]
        public async Task<IActionResult> Greetings(string? name)
        {
            string greetings = await Task.Run(() => $"Hello friend {name ?? "stranger"}!");
            return Ok(greetings);
        }
    }
}