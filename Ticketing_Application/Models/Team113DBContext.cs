using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace _665Project_ASP.Models
{
    public partial class Team113DBContext : DbContext
    {
        public Team113DBContext()
        {
        }

        public Team113DBContext(DbContextOptions<Team113DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<PurchasedEvents> PurchasedEvents { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=buscissql1601\\cisweb;Database=Team113DB;User ID=picka;Password=topic;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.Property(e => e.AdminId)
                    .HasColumnName("Admin_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("City_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.Property(e => e.EventId).HasColumnName("Event_Id");

                entity.Property(e => e.EventCity)
                    .IsRequired()
                    .HasColumnName("Event_City")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EventDate)
                    .HasColumnName("Event_Date")
                    .HasColumnType("date");

                entity.Property(e => e.EventDescription)
                    .IsRequired()
                    .HasColumnName("Event_Description")
                    .HasMaxLength(400);

                entity.Property(e => e.EventDuration).HasColumnName("Event_Duration");

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasColumnName("Event_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventOrganizerId).HasColumnName("Event_Organizer_ID");

                entity.Property(e => e.EventStartTime)
                    .IsRequired()
                    .HasColumnName("Event_Start_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EventStatus)
                    .IsRequired()
                    .HasColumnName("Event_Status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasColumnName("Event_Type")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EventVenue)
                    .IsRequired()
                    .HasColumnName("Event_Venue")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EventZip).HasColumnName("Event_Zip");

                entity.HasOne(d => d.EventOrganizer)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.EventOrganizerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Events_Users");
            });

            modelBuilder.Entity<PurchasedEvents>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.UserId });

                entity.ToTable("Purchased_Events");

                entity.Property(e => e.EventId).HasColumnName("Event_Id");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.PurchasedEvents)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Purchased_Events_Events");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PurchasedEvents)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Purchased_Events_Users");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => e.UserRolePk);

                entity.Property(e => e.UserRolePk)
                    .HasColumnName("UserRolePK")
                    .ValueGeneratedNever();

                entity.Property(e => e.UserRoleDescription)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.UserRoleName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UserType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_Users_1");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UserRoleFk).HasColumnName("UserRoleFK");

                entity.HasOne(d => d.UserRoleFkNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserRoleFk)
                    .HasConstraintName("FK_Users_Users");
            });
        }
    }
}
