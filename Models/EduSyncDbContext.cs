using System;
using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;

//namespace EduSyncAPIDemo.Models;

//public partial class EduSyncDbContext : DbContext
//{
//    public EduSyncDbContext()
//    {
//    }

//    public EduSyncDbContext(DbContextOptions<EduSyncDbContext> options)
//        : base(options)
//    {
//    }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-0ESIB2PT;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        OnModelCreatingPartial(modelBuilder);
//    }

//    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//}

using Microsoft.EntityFrameworkCore;

namespace EduSyncAPIDemo.Models
{
    public class EduSyncDbContext : DbContext
    {
        public EduSyncDbContext(DbContextOptions<EduSyncDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<Result> Results { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
