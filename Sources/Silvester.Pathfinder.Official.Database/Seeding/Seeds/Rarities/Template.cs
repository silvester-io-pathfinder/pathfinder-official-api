using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Rarities
{
    public abstract class Template : EntityTemplate<Rarity>
    {
        protected override Rarity GetEntity(ModelBuilder builder)
        {
            Rarity rarity = GetRaceRarity();
            return rarity;
        }

        protected abstract Rarity GetRaceRarity();
    }
}
