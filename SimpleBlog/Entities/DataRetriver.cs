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

                int commentCount = _context.Comments.Where(c => c.PostID == post.ID).Count();
                var temp= new PostsViewModel()
                {
                    ID = post.ID,
                    Author = post.Author,
                    Content = post.Content,
                    Date = post.Date,
                    PreviewText = post.PreviewText,
                    Tags = post.Tags.Split(',').ToList(),
                    Title = post.Title,
                    TotalComments = commentCount

                };
                
                data.Posts.Add(temp);
            }

            data.Tags = _context.Tags.ToList();
            data.Tags.OrderByDescending(t => t.TotalPost);


          

            return data;
        }

        public HomePageViewModel Search(string text)
        {
            var data = new HomePageViewModel();


            var posts = _context.Post.ToList();

            posts = posts.Where(p => p.Content.Contains(text)).ToList();




            foreach (var post in posts)
            {

                int commentCount = _context.Comments.Where(c => c.PostID == post.ID).Count();
                var temp = new PostsViewModel()
                {
                    ID = post.ID,
                    Author = post.Author,
                    Content = post.Content,
                    Date = post.Date,
                    PreviewText = post.PreviewText,
                    Tags = post.Tags.Split(',').ToList(),
                    Title = post.Title,
                    TotalComments = commentCount

                };

                data.Posts.Add(temp);
            }

            data.Tags = _context.Tags.ToList();
            data.Tags.OrderByDescending(t => t.TotalPost);




            return data;
        }

        public HomePageViewModel SearchTag(string text)
        {
            var data = new HomePageViewModel();


            var posts = _context.Post.ToList();

            posts = posts.Where(p => p.Tags.Contains(text)).ToList();




            foreach (var post in posts)
            {

                int commentCount = _context.Comments.Where(c => c.PostID == post.ID).Count();
                var temp = new PostsViewModel()
                {
                    ID = post.ID,
                    Author = post.Author,
                    Content = post.Content,
                    Date = post.Date,
                    PreviewText = post.PreviewText,
                    Tags = post.Tags.Split(',').ToList(),
                    Title = post.Title,
                    TotalComments = commentCount

                };

                data.Posts.Add(temp);
            }

            data.Tags = _context.Tags.ToList();
            data.Tags.OrderByDescending(t => t.TotalPost);




            return data;
        }

        public ContentViewModel RetriveContent(int ID)
        {

            var post = _context.Post.ToList().Find(p => p.ID == ID);

            var result = new ContentViewModel()
            {
                Id = ID,
                Title = post.Title,
                Content = post.Content,
                Tags = post.Tags.Split(',').ToList(),
                Date = post.Date,
                Comments = new List<Comment>()

            };

            var comments = _context.Comments.Where(c => c.PostID == ID).ToList();

            result.Comments = comments;
                



         


            return result;

        }

        public void SaveComment(Comment c)
        {
            _context.Comments.Add(c);

            _context.SaveChanges();
        }

    }
}
