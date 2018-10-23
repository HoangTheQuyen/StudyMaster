using System.ComponentModel.DataAnnotations;

namespace StudyMaster.Data.Entities
{
    public class Lecture
    {
        public long Id { get; set; }
        [Required]
        public string Description { get; set; }
        public Topic Topic { get; set; }
    }
}