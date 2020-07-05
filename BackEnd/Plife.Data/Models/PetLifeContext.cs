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
        public virtual DbSet<New> News { get; set; }
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
            modelBuilder.Entity<New>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.ToTable("news");
                entity.Property(e => e.ID).HasColumnName("id").ValueGeneratedOnAdd();
                entity.Property(e => e.Title)
                   .HasColumnName("title");
                entity.Property(e => e.Description)
                  .HasColumnName("description");
                entity.Property(e => e.Body)
                  .HasColumnName("body");
                entity.Property(e => e.IsDeleted)
                  .HasColumnName("is_deleted");
            });
        }

    }
}
