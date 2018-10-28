using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudyMaster.Data;

namespace StudyMaster.Features.Exams
{
    [Route("api/[controller]")]
    public class ExamsController : Controller
    {
        private readonly EFDataContext context;

        public ExamsController(EFDataContext ctx) => context = ctx;

        [HttpGet]
        public async Task<IActionResult> Find()
        {
            var exams = await context.Exams
                                     .Select(x => new ExamListViewModel
                                     {
                                         Id = x.Id,
                                         Description = x.Description,
                                         Thumbnail = x.Thumbnail,
                                         Slug = x.Slug,
                                         Type = x.Type
                                     })
                                     .ToListAsync();
            return Ok(exams);
        }

        [HttpGet("{slug}")]
        public async Task<IActionResult> Get(string slug)
        {
            var exam = await context.Exams.Select(x => new ExamListViewModel
            {
                Id = x.Id,
                Description = x.Description,
                Thumbnail = x.Thumbnail,
                Slug = x.Slug,
                Type = x.Type,
                Questions = x.Questions.Select(v => new ExamQuestionListViewModel{
                    Id = v.Id,
                    Content = v.Content,
                    AContent = v.AContent,
                    BContent = v.BContent,
                    CContent = v.CContent,
                    DContent = v.DContent,
                    CorrectAnswer = v.CorrectAnswer,
                    Explain = v.Explain
                })
            }).FirstOrDefaultAsync(x => x.Slug == slug);


            return Ok(exam);
        }
    }
}
