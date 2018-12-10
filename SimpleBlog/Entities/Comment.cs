using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlog.Entities
{
    public class Comment : IContent
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }

        public int PostID { get; set; }

        public int UserEmail { get; set; }



    }
}
