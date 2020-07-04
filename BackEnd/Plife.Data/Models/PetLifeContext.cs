using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plife.Data.Models
{
    public class PetLifeContext : DbContext
    {
        public PetLifeContext()
        {

        }
        public PetLifeContext(DbContextOptions options) : base(options)
        {

        }
        public virtual DbSet<WeatherForecast> WeatherForecasts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .Build();
                var conStr = configuration.GetConnectionString("PLifeDbContext");
                optionsBuilder.UseSqlServer(conStr);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherForecast>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.ToTable("weather_forecast");
                entity.Property(e => e.id).HasColumnName("id").UseIdentityColumn();
                entity.Property(e => e.Date)
                   .HasColumnName("date");
                entity.Property(e => e.TemperatureC)
                  .HasColumnName("temperature_c");
                entity.Property(e => e.Summary)
                  .HasColumnName("summary");
            });
        }

    }
}
