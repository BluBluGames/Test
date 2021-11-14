using Microsoft.EntityFrameworkCore;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate;
using Test.NotificationScheduling.Domain.V1.CompanyAggregate.ScheduleEntity;

namespace Test.NotificationScheduling.Infrastructure.Contexts
{
    public class NotificationSchedulingContext : DbContext
    {
        public NotificationSchedulingContext(DbContextOptions<NotificationSchedulingContext> options) : base(options)
        {
        }
        
        public DbSet<Company> Companies { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .OwnsOne(c => c.Name, a => a.Property(p => p.Value)
                    .HasColumnName("Name")
                    .IsRequired());
            modelBuilder.Entity<Company>()
                .OwnsOne(c => c.Name, a => a.Property(p => p.Value)
                    .HasColumnName("Name")
                    .IsRequired());
            modelBuilder.Entity<Company>()
                .OwnsOne(c => c.Number, a => a.Property(p => p.Value)
                    .HasColumnName("Number")
                    .IsRequired());
            modelBuilder.Entity<Company>()
                .OwnsOne(c => c.Number, a => a.Property(p => p.Value)
                    .HasColumnName("Number")
                    .IsRequired());
            modelBuilder.Entity<Company>()
                .OwnsOne(c => c.CompanyType, a => a.Property(p => p.Value)
                    .HasColumnName("Type")
                    .IsRequired());
            modelBuilder.Entity<Company>()
                .OwnsOne(c => c.Market, a => a.Property(p => p.Value)
                    .HasColumnName("Market")
                    .IsRequired());
            
            modelBuilder.Entity<Notification>()
                .HasOne(n => n.Company)
                .WithMany(c => c.Notifications);
            modelBuilder.Entity<Notification>()
                .OwnsOne(n => n.SendingDate, a => a.Property(p => p.Value)
                    .HasColumnName("SendingDate")
                    .IsRequired());
        }
    }
}