using ITMO.ASP.StudentRecords.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.ASP.StudentRecords.DAL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Score> Scores { get; set; }

        public ApplicationContext()
            : base("StudentDB")
        { 
           
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Student>().HasKey(p => p.Id);
        //    modelBuilder.Entity<Student>().Property(t => t.FirstName)
        //                                  //.HasColumnType("varchar")
        //                                  .HasMaxLength(20)
        //                                  .IsRequired()
        //                                  .IsUnicode(true);
        //    modelBuilder.Entity<Student>().Property(t => t.LastName)
        //                                  //.HasColumnType("varchar")
        //                                  .HasMaxLength(30)
        //                                  .IsRequired()
        //                                  .IsUnicode(true);
        //    modelBuilder.Entity<Student>().Property(t => t.ScoreId).IsRequired();

        //    modelBuilder.Entity<Score>().HasKey(p => p.Id);
        //    modelBuilder.Entity<Score>().Property(t => t.ScoreValue)
        //                                .IsRequired();
        //    modelBuilder.Entity<Score>().Property(t => t.ScoreDescription)
        //                                .HasColumnType("varchar")
        //                                .HasMaxLength(19)
        //                                .IsUnicode(true);
        //}
    }
}
