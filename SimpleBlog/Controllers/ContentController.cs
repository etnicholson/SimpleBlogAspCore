using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleBlog.Data;
using SimpleBlog.Entities;

namespace SimpleBlog.Controllers
{
    public class ContentController : Controller
    {
        private DataRetriver data;

        public ContentController(ApplicationDbContext context)
        {
            data = new DataRetriver(context);
        }
        [HttpGet]
        public IActionResult View(int id)
        {
            var content = data.RetriveContent(id);

            return View(content);
        }

        [HttpPost]
        public IActionResult Search(string text)
        {
            text = text.Trim();
            var content = data.Search(text);
            ViewData["text"] = text;
            return View(content);
        }
        [Route("content/searchtag/{text}")]
        public IActionResult SearchTag(string text)
        {

            text = text.Trim();
            var content = data.SearchTag(text);
            ViewData["text"] = text;
            return View(content);
        }


        [HttpPost]
        public IActionResult Comment(int id,string name, string comment)
        {
            var c = new Comment(){PostID = id,Author = name,Content = comment};

            data.SaveComment(c);
            return Redirect($"/content/view/{id}");
        }



    }
}