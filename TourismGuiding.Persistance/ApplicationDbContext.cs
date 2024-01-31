using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismGuiding.Entities;
using TourismGuiding.Entities.Account;
using TourismGuiding.Entities.NewFolder;
using TourismGuiding.Entities.Services;

namespace TourismGuiding.Persistance
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.Entity<City>().HasMany<ImagesOfCity>().WithOne()
                .HasPrincipalKey(x => x.CityId).HasForeignKey(x => x.CityId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Place>().HasMany<ImagesOfPlace>().WithOne()
              .HasPrincipalKey(x => x.PlaceId).HasForeignKey(x => x.PlaceId)
              .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<City> cities { get; set; }
        public DbSet<Place> places { get; set; }
        public DbSet<Tourism> typesOfTourism { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<ImagesOfCity> imagesOfCities   { get; set; }
        public DbSet<ImagesOfPlace> imagesOfPlaces { get; set; }

    }
}
