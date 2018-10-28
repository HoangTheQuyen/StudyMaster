using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudyMaster.Data.Entities
{
    public class Exam
    {
        public long Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Thumbnail { get; set; }
        [Required]
        public string Slug { get; set; }
        [Required]
        public string Type { get; set; }
        public long SubjectId { get; set; }
        public Subject Subject { get; set; }
        public Topic Topic { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
    }
}