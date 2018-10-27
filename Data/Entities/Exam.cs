using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudyMaster.Data.Entities
{
    public class Exam
    {
        public long Id { get; set; }
        [Required]
        public string Description { get; set; }
        public Topic Topic { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
    }
}