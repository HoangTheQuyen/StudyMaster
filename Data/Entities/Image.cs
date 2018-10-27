using System.ComponentModel.DataAnnotations;

namespace StudyMaster.Data.Entities
{
    public class Image
    {
        public long Id { get; set; }
        [Required]
        public string Url { get; set; }
        public Topic Topic { get; set; }
    }
}