using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMaster.Models
{

    public class Selection
    {
        public long SelectionId { get; set; }

        public string Content { get; set; }

        public bool check { get; set; }

        public Question Question { get; set; }
        public long QuestionId { get; set; }
    }
}
