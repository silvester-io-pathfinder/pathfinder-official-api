using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.MagicEssences
{
    public abstract class Template : EntityTemplate<MagicEssence>
    {
        protected override MagicEssence GetEntity(ModelBuilder builder)
        {
            MagicEssence essence = GetMagicEssence();
            return essence;
        }

        protected abstract MagicEssence GetMagicEssence();
    }
}
