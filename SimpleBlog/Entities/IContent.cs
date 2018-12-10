using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlog.Entities
{
    interface IContent

    {
        int ID { get; set; }
        string Content { get; set; }

        string Author { get; set; }
        DateTime Date { get; set; }


    }
}
