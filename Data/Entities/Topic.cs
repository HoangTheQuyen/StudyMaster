using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudyMaster.Data.Entities
{
    public class Topic
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Slug { get; set; }
        [Required]
        public string LectureContent { get; set; }
        [Required]      
        public string Thumbnail{get;set;}
        public long? ExamId { get; set; }
        public Exam Exam { get; set; }
        public long SubjectId { get; set; }
        public Subject Subject { get; set; }
        
    }
}