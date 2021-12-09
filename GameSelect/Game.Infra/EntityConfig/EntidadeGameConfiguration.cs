using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Mercurio.WebApp.Infra.Data.EntityConfig
{
    public class EntidadeGameConfiguration : IEntityTypeConfiguration<EntidadeGame>
    {
        public void Configure(EntityTypeBuilder<EntidadeGame> builder)
        {
            builder.Property(x => x.EntidadeGameGuid)
                .HasColumnType("char(36)");

            builder.HasIndex(x => x.EntidadeGameGuid)
                .HasName("IDX_GUID")
                .IsUnique();
                       

        }

        internal static void Seed(EntityTypeBuilder<EntidadeGame> builder)
        {
            builder.HasData(
                new EntidadeGame(1, Guid.NewGuid(), "The Legend of Zelda: Ocarina of Time(N64)", 1998, 99.8),
                new EntidadeGame(2, Guid.NewGuid(), "Tony Hawk's Pro Skater 2 (PS)", 2000, 98.9),
                new EntidadeGame(3, Guid.NewGuid(), "Grand Theft Auto IV (PS3)", 2008, 98.9),
                new EntidadeGame(4, Guid.NewGuid(), "Grand Theft Auto IV (X360)", 2008, 98.9),
                new EntidadeGame(5, Guid.NewGuid(), "SoulCalibur (DC)", 1999, 98.9),
                new EntidadeGame(6, Guid.NewGuid(), "Super Mario Galaxy (WII)", 2007, 97.9)
           

            );
        }
    }
}