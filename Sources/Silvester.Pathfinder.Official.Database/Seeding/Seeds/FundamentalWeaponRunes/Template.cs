using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.FundamentalWeaponRunes
{
    public abstract class Template : EntityTemplate<FundamentalWeaponRune>
    {
        protected override FundamentalWeaponRune GetEntity(ModelBuilder builder)
        {
            FundamentalWeaponRune rune = GetRune();

            builder.AddSourcePage(rune, GetSourcePage(), e => e.SourcePage);
            builder.AddTraits(rune, GetTraits());
            builder.AddTextBlocks(rune, GetDetails(), e => e.Details);

            foreach(FundamentalWeaponRuneVariant level in GetLevels())
            {
                level.RuneId = rune.Id;
                builder.AddData(level);
            }

            return rune;
        }

        protected abstract IEnumerable<FundamentalWeaponRuneVariant> GetLevels();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract SourcePage GetSourcePage();
        protected abstract FundamentalWeaponRune GetRune();
    }
}
