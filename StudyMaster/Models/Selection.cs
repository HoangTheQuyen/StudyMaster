using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMaster.Models
{

    public class Selection
    {
        public long SelectionId { get; set; }

        public string ContentA { get; set; }
        public string ContentB { get; set; }
        public string ContentC { get; set; }
        public string ContentD { get; set; }

        public long QuestionId { get; set; }
    }
}
