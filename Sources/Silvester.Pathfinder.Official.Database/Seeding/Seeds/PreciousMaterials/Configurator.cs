using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterials
{
    public class Configurator : EntityConfigurator<PreciousMaterial>
    {
        public override void Configure(ModelBuilder builder)
        {
            base.Configure(builder);

            builder
                .Entity<PreciousMaterial>()
                .HasOne(e => e.Weapon)
                .WithOne(e => e.Material)
                .HasForeignKey<PreciousMaterial>(e => e.WeaponId);

            builder
                .Entity<PreciousMaterial>()
                .HasOne(e => e.Armor)
                .WithOne(e => e.Material)
                .HasForeignKey<PreciousMaterial>(e => e.ArmorId);

            builder
                .Entity<PreciousMaterial>()
                .HasOne(e => e.Shield)
                .WithOne(e => e.Material)
                .HasForeignKey<PreciousMaterial>(e => e.ShieldId);
        }
    }

    public class SearchConfigurator : SearchableEntityConfigurator<PreciousMaterial>
    {
        public override Expression<Func<PreciousMaterial, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
