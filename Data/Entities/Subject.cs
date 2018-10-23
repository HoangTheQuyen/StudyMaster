using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace StudyMaster.Data.Entities
{
    public class Subject
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public List<Topic> Products { get; set; } = new List<Topic>();
    }
}