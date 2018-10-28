
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudyMaster.Data;

namespace StudyMaster.Features.Filters
{
    [Route("api/[controller]")]
    public class FiltersController : Controller
    {
        private readonly EFDataContext context;
        public FiltersController(EFDataContext ctx) => context = ctx;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var subjects = await context.Subjects
                                        .Select(x => x.Name)
                                        .ToListAsync();

                return Ok(new FiltersListViewModel
                {
                    Subjects = subjects
                });
        }
    }
}