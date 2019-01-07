using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlog.Entities
{
    public class Tags
    {
        public int ID { get; set; }
        public string Tag { get; set; }
        public int TotalPost { get; set; }
        public  string PostsID { get; set; }
       
    }
}
