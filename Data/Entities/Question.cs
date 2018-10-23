using System.ComponentModel.DataAnnotations;

namespace StudyMaster.Data.Entities
{
    public class Question
    {
        public long Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string explain { get; set; }
        [Required]
        public int CorrectAnswer { get; set; }
        [Required]
        public string AContent { get; set; }
        [Required]
        public string BContent { get; set; }
        [Required]
        public string CContent { get; set; }
        [Required]
        public string DContent { get; set; }

        public Exam Exam { get; set; }
        public long ExamId { get; set; }
    }
}