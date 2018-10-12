using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMaster.Models
{

    public class Question
    {
        public long QuestionId { get; set; }
        public string Content { get; set; }
        public string Answer { get; set; }

        public IEnumerable<Selection> Selections { get; set; }
    }
}
