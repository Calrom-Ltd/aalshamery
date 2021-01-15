// <copyright file="dbAPITestContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WebAPIapplication.Model
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata;

    /// <summary>
    /// this class connect to the database.
    /// </summary>
    public partial class DbAPITestContext : DbContext, IDbAPITestContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DbAPITestContext"/> class.
        /// this is the constractor of the class.
        /// </summary>
        public DbAPITestContext()
        {
        }
        #pragma warning disable SA1614 // Element parameter documentation should have text
        /// <summary>
        /// Initializes a new instance of the <see cref="DbAPITestContext"/> class.
        /// this is a nother constractor.
        /// </summary>
        /// <param name="options"></param>
        public DbAPITestContext(DbContextOptions<DbAPITestContext> options)
        #pragma warning restore SA1614 // Element parameter documentation should have text
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets from TblLogins table in the database.
        /// </summary>
        public virtual DbSet<TblLogin> TblLogins { get; set; }

        /// <summary>
        /// Gets or sets from tbl_User_Massages table in the database.
        /// </summary>
        public virtual DbSet<Tbl_User_Massage> Tbl_User_Massages { get; set; }

        #pragma warning disable SA1614 // Element parameter documentation should have text
        /// <summary>
        /// this helps to connect to the database.
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        #pragma warning restore SA1614 // Element parameter documentation should have text
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-GEFU4OC\\SQLEXPRESS;Initial Catalog=dbAPITest;Integrated Security=True");
            }
        }

        #pragma warning disable SA1614 // Element parameter documentation should have text
        /// <summary>
        /// this helps to connect to the tables in the database.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        #pragma warning restore SA1614 // Element parameter documentation should have text
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");


            modelBuilder.Entity<TblLogin>(entity =>
            {
                entity.ToTable("tbl_Login");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });
            modelBuilder.Entity<Tbl_User_Massage>(entity =>
            {
                entity.ToTable("tbl_User_Massage");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateOfBirth).HasColumnName("DateOfBirth");

                entity.Property(e => e.Subject).HasColumnName("Subject");
                entity.Property(e => e.Messages).HasColumnName("Messages");
                entity.Property(e => e.Userid).HasColumnName("User_id");
            });

            this.OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
