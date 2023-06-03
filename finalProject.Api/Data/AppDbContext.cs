﻿using Microsoft.EntityFrameworkCore;

namespace finalProject.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users => Set<User>();
        public DbSet<PDCharacter> PDCharacters => Set<PDCharacter>();
    }
}
