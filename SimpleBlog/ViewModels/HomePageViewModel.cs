using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleBlog.Entities;

namespace SimpleBlog.ViewModels
{
    public class HomePageViewModel
    {
        public List<PostsViewModel> Posts { get; set; }
        public List<Tags> Tags { get; set; }

        public HomePageViewModel()
        {
            Posts = new List<PostsViewModel>();
            Tags = new List<Tags>();
        }
    }
}
