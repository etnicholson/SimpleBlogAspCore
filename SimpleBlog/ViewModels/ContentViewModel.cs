using SimpleBlog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlog.ViewModels
{
    public class ContentViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public List<Comment> Comments { get; set; }

        public List<string> Tags { get; set; }
    }
}
