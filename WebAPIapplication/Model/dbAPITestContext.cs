using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebAPIapplication.Model
{
    public partial class dbAPITestContext : DbContext
    {
        public dbAPITestContext()
        {
        }

        public dbAPITestContext(DbContextOptions<dbAPITestContext> options)
            : base(options)
        {
        }

        
        public virtual DbSet<TblLogin> TblLogins { get; set; }
        public virtual DbSet<tbl_User_Massage> tbl_User_Massages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=DESKTOP-GEFU4OC\\SQLEXPRESS;Initial Catalog=dbAPITest;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");


            modelBuilder.Entity<TblLogin>(entity =>
            {
                entity.ToTable("tbl_Login");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });
            modelBuilder.Entity<tbl_User_Massage>(entity =>
            {
                entity.ToTable("tbl_User_Massage");

                entity.Property(e => e.id).HasColumnName("ID");

                entity.Property(e => e.DateOfBirth).HasColumnName("DateOfBirth");

                entity.Property(e => e.Subject).HasColumnName("Subject");
                entity.Property(e => e.Messages).HasColumnName("Messages");
                entity.Property(e => e.User_id).HasColumnName("User_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
