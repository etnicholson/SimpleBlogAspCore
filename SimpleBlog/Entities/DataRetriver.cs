using SimpleBlog.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleBlog.ViewModels;

namespace SimpleBlog.Entities
{
    public class DataRetriver : IDataRetriver
    {
        private readonly ApplicationDbContext _context;

        public DataRetriver(ApplicationDbContext context)
        {
            
            _context = context;
        }

        public HomePageViewModel Retrive()
        {
            var data = new HomePageViewModel();

            var posts = _context.Post.ToList();

            foreach (var post in posts)
            {
                var temp= new PostsViewModel()
                {
                    ID = post.ID,
                    Author = post.Author,
                    Content = post.Content,
                    Date = post.Date,
                    PreviewText = post.PreviewText,
                    Tags = post.Tags,
                    Title = post.Title,
                    TotalComments = 0

                };
                
                data.Posts.Add(temp);
            }

            data.Tags = _context.Tags.ToList();
            data.Tags.OrderByDescending(t => t.TotalPost);


          

            return data;
        }

    }
}
