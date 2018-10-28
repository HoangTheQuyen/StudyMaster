using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyMaster.Features.Topics
{
    public class TopicListViewModel
    {
        public long Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Thumbnail { get; set; }
        public string LectureContent { get; set; }
    }
}
