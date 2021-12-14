using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Dominio.Entidades;
using Mercurio.WebApp.Infra.Data.EntityConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Game.Infra.Context
{
    public sealed class GameContext : DbContext
    {
        public DbSet<EntidadeGame> Game { get; set; }

        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {                    
                    
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            if (modelBuilder != null)
            {
                ApplyDefaultConfiguration(modelBuilder);
                ApplyEntityConfiguration(modelBuilder);
            }

            base.OnModelCreating(modelBuilder);           
        }


        private static void ApplyDefaultConfiguration(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(t => t.GetProperties()).Where(p =>
                p.ClrType == typeof(string) && p.Name.Equals(p.FieldInfo.ReflectedType?.Name + "Id")))
                property.IsKey();

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(t => t.GetProperties()).Where(p => p.ClrType == typeof(Guid)))
                property.SetMaxLength(36);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.Restrict;                       

        }

        private static void ApplyEntityConfiguration(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new EntidadeGameConfiguration());

            // Popular a Base no Primeiro Update-Base

            EntidadeGameConfiguration.Seed(modelBuilder.Entity<EntidadeGame>());            
        }

    }
}
