using Microsoft.EntityFrameworkCore;
using System;
using WebApiGraphQL.Domain.Entities;

namespace WebApiGraphQL.Infrastructure
{
    public class AppContextClass : DbContext
    {

        public AppContextClass(DbContextOptions<AppContextClass> options) : base(options) { }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
