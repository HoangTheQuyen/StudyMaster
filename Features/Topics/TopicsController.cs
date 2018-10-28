using System.Collections.Generic;
using System.Linq;
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
        public async Task<IActionResult> Find(string subjects)
        {
            var Subjects = string.IsNullOrEmpty(subjects) ? new List<string>() : subjects.Split('|').ToList();

            var topics = await context.Topics
                                      .Where(x => Subjects.Any() == false || Subjects.Contains(x.Subject.Name))
                                      .Select(x => new TopicListViewModel
                                      {
                                          Id = x.Id,
                                          Slug = x.Slug,
                                          Name = x.Name,
                                          Thumbnail = x.Thumbnail,
                                          LectureContent = x.LectureContent
                                      })
                                      .ToListAsync();

            return Ok(topics);
        }

        [HttpGet("{slug}")]
        public async Task<IActionResult> Get(string slug)
        {
            var topic = await context.Topics.SingleOrDefaultAsync(x => x.Slug == slug);

            if (topic == null) return NotFound();

            return Ok(topic);
        }
    }
}