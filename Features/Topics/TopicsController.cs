using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudyMaster.Data;

namespace StudyMaster.Features.Topics
{
    [Route("api/[controller]")]
    public class TopicsController : Controller
    {
        private readonly EFDataContext context;
        public TopicsController(EFDataContext ctx) => context = ctx;

        [HttpGet]
        public async Task<IActionResult> Find(){
            var topics = await context.Topics.ToListAsync();

            return Ok(topics);
        }

        [HttpGet("{slug}")]
        public async Task<IActionResult> Get(string slug){
            var topic = await context.Topics.SingleOrDefaultAsync(x => x.Slug == slug);
            
            if(topic == null) return NotFound();

            return Ok(topic);
        }
    }
}