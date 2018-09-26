using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMaster.Models
{
    public enum Select
    {
        a, b, c, d
    }
    public class Selection
    {
        public long SelectionId { get; set; }

        public IEnumerable<Dictionary<Select, string>> Select { get; set; }

        public Question QuestionId { get; set; }
    }
}
