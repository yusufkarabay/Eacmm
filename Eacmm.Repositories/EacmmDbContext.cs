using Eacmm.Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Eacmm.Repositories
{
    public class EacmmDbContext : DbContext
    {
        public EacmmDbContext(DbContextOptions<EacmmDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Cabinet> Cabinets { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Drawer> Drawers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EntranceCard> EntranceCards { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<GeneratorUsedTime> GeneratorUsedTimes { get; set; }
        public DbSet<GuestCard> GuestCards { get; set; }
        public DbSet<Headset> Headsets { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<PasswordNote> PasswordNotes { get; set; }
        public DbSet<PhoneDirectory> PhoneDirectories { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<SentryDone> SentryDones { get; set; }
        public DbSet<SentryToDo> SentryToDos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Cabinet>()
                .HasOne(c => c.Employee)
                .WithMany(e => e.Cabinets)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Drawer>()
                .HasOne(c => c.Employee)
                .WithMany(e => e.Drawers)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<EntranceCard>()
                .HasOne(c => c.Employee)
                .WithMany(e => e.EntranceCards)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Employee>()
                .HasOne(c => c.Department)
                .WithMany(e => e.Employees)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<GuestCard>()
                .HasOne(c => c.Employee)
                .WithMany(e => e.GuestCards)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Headset>()
                .HasOne(c => c.Employee)
                .WithMany(e => e.Headsets)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Headset>()
                .HasOne(c => c.Employee)
                .WithMany(e => e.Headsets)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SentryToDo>()
               .HasOne(c => c.Department)
               .WithMany(e => e.SentryToDos)
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SentryDone>()
                .HasOne(c => c.Department)
                .WithMany(e => e.SentryDones)
                .OnDelete(DeleteBehavior.NoAction);


        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            foreach (var entity in ChangeTracker.Entries().Where(e => e.State == EntityState.Modified))
            {
                var baseEntity = entity.Entity as BaseEntity;
                baseEntity.Version++;
                baseEntity.LastModifiedAt = DateTime.Now;
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }

}
