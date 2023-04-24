using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace Fileuploaddbc.Models
{
    public partial class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public virtual DbSet<FileUploadViewModel>FileUpload { get; set; }
        public virtual DbSet<FileOnDatabaseModel> FilesOnDatabase { get; set; }
        public virtual DbSet<FileOnFileSystemModel> FilesOnFileSystem { get; set; }
        /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             if (!optionsBuilder.IsConfigured)
             {
 #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                 optionsBuilder.UseSqlServer("Server=LAPTOP-5UAB0E06;Database=Inventory;User id=sa;Password=Oasys@1234");
             }
         }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FileUploadViewModel>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_Products_B40CC6CD73B27013");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.FileType)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Extension)
                    .HasMaxLength(10)
                    .IsFixedLength();
                entity.Property(e => e.Description)
                  .HasMaxLength(10)
                  .IsFixedLength();

                entity.Property(e => e.UploadedBy)
                    .HasMaxLength(2000)
                    .IsFixedLength();
                entity.Property(e => e.CreatedOn)
                  .HasMaxLength(15)
                  .IsFixedLength();

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
