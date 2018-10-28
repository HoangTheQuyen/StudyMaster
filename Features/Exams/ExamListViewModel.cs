using StudyMaster.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMaster.Features.Exams
{
    public class ExamListViewModel
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public string Thumbnail { get; set; }
        public string Type { get; set; }
        public IEnumerable<ExamQuestionListViewModel> Questions { get; set; }
    }
}
