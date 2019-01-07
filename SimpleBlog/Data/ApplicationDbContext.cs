using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimpleBlog.Entities;

namespace SimpleBlog.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Comment> Comments;

        public DbSet<SimpleBlog.Entities.Post> Post { get; set; }
        public DbSet<SimpleBlog.Entities.Tags> Tags { get; set; }

    }

}
