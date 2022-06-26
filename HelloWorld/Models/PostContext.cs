using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HelloWorld.Models;

namespace HelloWorld.Models
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions<PostContext> options):base(options)
        {
            //Database.EnsureCreated();
        }

        public IEnumerable<Post> Posts
        {
            get
            {
                return new[]
                {
                    new Post
                    {
                        id = 1,
                        post = "this sample post is not from database",
                        postedDateTime = DateTime.Now
                    },
                    new Post
                    {
                        id = 1,
                        post = "sample post not from database",
                        postedDateTime= DateTime.Now
                    },
                    new Post
                    {
                        id = 1,
                        post= "post not fro databasee",
                        postedDateTime = DateTime.Now
                    }
            };
            }
        }
    }
}
