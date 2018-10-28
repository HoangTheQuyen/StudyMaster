using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudyMaster.Data;

namespace StudyMaster.Features.Users
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly EFDataContext context;
        public UsersController(EFDataContext ctx) => context = ctx;
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await context.Users.ToListAsync());
        }
    }
}