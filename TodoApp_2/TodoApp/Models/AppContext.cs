﻿using System.Data.Entity;

namespace TodoApp.Models
{
    public class AppContext : DbContext
    {
        /*
        public AppContext() : base("name=TodoDbConnection")
        {
        }
        */
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Todo> Todoes { get; set; }
    }
}
