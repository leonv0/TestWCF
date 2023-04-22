using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ImportService
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ARM> ARMs { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Flight_Number> Flight_Number { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ARM>()
                .Property(e => e.ARM_Name)
                .IsUnicode(false);

            modelBuilder.Entity<ARM>()
                .HasMany(e => e.Sessions)
                .WithRequired(e => e.ARM)
                .HasForeignKey(e => e.ARM_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Flight>()
                .HasMany(e => e.Passengers)
                .WithRequired(e => e.Flight)
                .HasForeignKey(e => e.Flight_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Flight_Number>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<Flight_Number>()
                .Property(e => e.Time)
                .HasPrecision(0);

            modelBuilder.Entity<Flight_Number>()
                .HasMany(e => e.Flights)
                .WithRequired(e => e.Flight_Number)
                .HasForeignKey(e => e.Flight_Number_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Passenger>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Passenger>()
                .Property(e => e.Reservation_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Passenger>()
                .Property(e => e.DocumentNumber)
                .IsFixedLength();

            modelBuilder.Entity<Registration>()
                .Property(e => e.First_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.Flight_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.Flight_Time)
                .IsUnicode(false);

            modelBuilder.Entity<Session>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Session>()
                .HasMany(e => e.Registrations)
                .WithOptional(e => e.Session)
                .HasForeignKey(e => e.Session_ID);
        }
    }
}
