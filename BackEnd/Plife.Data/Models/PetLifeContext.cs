using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Plife.Global.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plife.Data.Models
{
    public partial class PetLifeContext : DbContext
    {
        public PetLifeContext()
        {

        }
        public PetLifeContext(DbContextOptions<PetLifeContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(AppSettings.ConnectionString);
        }
        public virtual DbSet<WeatherForecast> WeatherForecasts { get; set; }

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
