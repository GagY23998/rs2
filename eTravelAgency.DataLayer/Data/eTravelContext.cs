using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using eTravelAgency.Core.Models;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace eTravelAgency.DataLayer.Data
{

    public class eTravelDesignTimeFactory : IDesignTimeDbContextFactory<eTravelContext>
    {
        public eTravelContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<eTravelContext>();
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=IB160171;Trusted_Connection=True;MultipleActiveResultSets=true";
            builder.UseSqlServer(connectionString);

            return new eTravelContext(builder.Options);
        }
    }

    public class eTravelContext : DbContext
    {
        public eTravelContext(DbContextOptions options):base(options)
        {
           
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelOffer> HotelOffers { get; set; }
        //public DbSet<HotelRooms> HotelRooms { get; set; }
        //public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<TransportCompany> TransportCompanies { get; set; }
        public DbSet<TransportType> TransportTypes { get; set; }
        public DbSet<TransportOffer> TransportOffers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Attraction> Attractions { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryFavorites> CountryFavorites { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CountryFavorites>().HasKey(cf => new {cf.UserId,cf.CountryId });
            modelBuilder.Entity<UserRoles>().HasKey(key => new { key.UserId,key.RoleId});
         //   modelBuilder.Entity<HotelRooms>().HasKey(key => new {key.HotelId,key.RoomTypeId });
         
        }
    }
    
}
