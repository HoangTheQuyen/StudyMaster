using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudyMaster.Data.Entities
{
    public class Subject
    {
        public long Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Thumbnail { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Topic> Topics { get; set; } = new List<Topic>();
    }
}