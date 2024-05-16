using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ProgramContext : DbContext
    {
        public DbSet<ApplicationFormFormat>? ApplicationFormFormats { get; set; }
        public DbSet<ApplicationFormData>? ApplicationFormDataSet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationFormFormat>()
                .ToContainer("ApplicationFormFormats")
                .HasPartitionKey(e => e.Id);

            modelBuilder.Entity<ApplicationFormData>()
                .ToContainer("ApplicationFormDataSet")
                .HasPartitionKey(e => e.Id);

            modelBuilder.Entity<ApplicationFormFormat>().OwnsMany(item => item.ParagraphQuestion);
            modelBuilder.Entity<ApplicationFormFormat>().OwnsMany(item => item.NumericQuestion);
            modelBuilder.Entity<ApplicationFormFormat>().OwnsMany(item => item.DateQuestion);
            modelBuilder.Entity<ApplicationFormFormat>().OwnsMany(item => item.YesNoQuestion);
            modelBuilder.Entity<ApplicationFormFormat>().OwnsMany(item => item.DropdownQuestion);
            modelBuilder.Entity<ApplicationFormFormat>().OwnsMany(item => item.MultipleChoiceQuestion);

            modelBuilder.Entity<ApplicationFormData>().OwnsMany(item => item.ParagraphQuestion);
            modelBuilder.Entity<ApplicationFormData>().OwnsMany(item => item.NumericQuestion);
            modelBuilder.Entity<ApplicationFormData>().OwnsMany(item => item.DateQuestion);
            modelBuilder.Entity<ApplicationFormData>().OwnsMany(item => item.YesNoQuestion);
            modelBuilder.Entity<ApplicationFormData>().OwnsMany(item => item.DropdownQuestion);
            modelBuilder.Entity<ApplicationFormData>().OwnsMany(item => item.MultipleChoiceQuestion);


        }

    }
}
