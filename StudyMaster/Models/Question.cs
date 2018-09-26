using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMaster.Models
{
    public enum Result
    {
        a,b,c,d
    }
    public class Question
    {
        public long QuestionId { get; set; }
        public string Content { get; set; }
        public Result Result { get; set; }
        public string Answer { get; set; }

        public Selection Selection { get; set; }
    }
}
