using System;
using System.Data.Entity;
using Sample01.Models;

namespace Sample01.Config
{
    public class MyContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }

        public MyContext()
            : base("Connection1")
        {
            this.Database.Log = sql => Console.Write(sql);
        }
    }
}