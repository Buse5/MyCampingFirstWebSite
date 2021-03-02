using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CamperProject.Models
{
    public class Camp
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public bool IsPublish { get; set; }

        public DateTime CreateTime { get; set; } = DateTime.Now;
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public Region Region { get; set; }
        public int RegionId { get; set; }
    }
}
