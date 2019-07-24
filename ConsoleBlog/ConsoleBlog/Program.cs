using Intro;
using System;

namespace ConsoleBlog
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                db.Database.EnsureCreated();
                var blog = new Blog { Url = "http://sample.com" };
                db.Blogs.Add(blog);
                db.SaveChanges();

                foreach (var blogEntry in db.Blogs)
                {
                    Console.WriteLine($"{blog.BlogId}");
                }
            }
        }
    }
}
