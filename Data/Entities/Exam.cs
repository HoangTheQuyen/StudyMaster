using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace StudyMaster.Data.Entities
{
    public class Exam
    {
        public long Id { get; set; }
        [Required]
        public string Description { get; set; }
        
        

        public List<Question> Products { get; set; } = new List<Question>();
    }
}