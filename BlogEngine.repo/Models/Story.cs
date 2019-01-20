using System;
using System.Collections.Generic;
using System.Text;

namespace BlogEngine.repo.Models
{
    public class Story
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public long CreationTime { get; set; }
        public long LastEditTime { get; set; }
        public long PublishTime { get; set; }
        public bool Draft { get; set; }
    }
}
