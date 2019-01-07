using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlog.ViewModels
{
    public class PostsViewModel
    {
        public int ID { get; set; }
        public string Content { get; set; }

        public string PreviewText { get; set; }
        public string Author { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string Title { get; set; }

        public string Tags { get; set; }

        public int TotalComments { get; set; }
    }
}
