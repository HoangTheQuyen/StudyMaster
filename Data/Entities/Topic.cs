using System.ComponentModel.DataAnnotations;

namespace StudyMaster.Data.Entities
{
    public class Topic
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        public long SubjectId { get; set; }
        public Subject Subject { get; set; }

       public long? ExamId { get; set; }
        public Exam Exam { get; set; }
        public long? LectureId { get; set; }
        public Lecture Lecture { get; set; }
    }
}