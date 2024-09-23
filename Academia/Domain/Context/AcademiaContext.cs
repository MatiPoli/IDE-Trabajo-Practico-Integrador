﻿using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace Domain.Context
{
    internal class AcademiaContext : DbContext
    {
        internal DbSet<Persona> Personas { get; set; }
        internal DbSet<Plan> Planes { get; set; }
        internal DbSet<Especialidad> Especialidades { get; set; }

        internal AcademiaContext()
        {
            //this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Academia;Integrated Security=true");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>()
                .HasOne(p => p.Plan)
                .WithMany();

            modelBuilder.Entity<Plan>()
                .HasOne(p => p.Especialidad)
                .WithMany();
        }

    }

}
