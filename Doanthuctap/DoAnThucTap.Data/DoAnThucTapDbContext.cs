using DoAnThucTap.DTOs.Config;
using DoAnThucTap.DTOs.Entyties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.Data
{
    public class DoAnThucTapDbContext:DbContext
    {
        public DoAnThucTapDbContext(DbContextOptions options) : base(options){}
        public DbSet<Book>books { get; set; }
        public DbSet<CategoryBook>categoryBooks { get; set; }
        public DbSet<ClassRoom>classRooms { get; set; }
        public DbSet<ImageBook>imageBooks { get; set; }
        public DbSet<Invoke>invokes { get; set; }
        public DbSet<InvokeDetails>invokeDetails { get; set; }
        public DbSet<Notication>notications { get; set; }
        public DbSet<Policy>policies { get; set; }
        public DbSet<Rules>rules { get; set; }
        public DbSet<User>Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfig());
            modelBuilder.ApplyConfiguration(new ImageBookConfig());
            modelBuilder.ApplyConfiguration(new InvokeDetailsConfig());
           
            
        }
    }
}
