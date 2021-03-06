using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorGroups
{
    public abstract class Template : EntityTemplate<ArmorGroup>
    {
        protected override ArmorGroup GetEntity(ModelBuilder builder)
        {
            ArmorGroup group = GetArmorGroup();

            builder.AddSourcePage(group, GetSourcePage(), e => e.SourcePageId);

            return group;
        }

        protected abstract SourcePage GetSourcePage();
        protected abstract ArmorGroup GetArmorGroup();
    }
}
