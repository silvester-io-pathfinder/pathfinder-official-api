﻿using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialWeapons
{
    public abstract class Template : EntityTemplate<PreciousMaterialWeapon>
    {
        protected override PreciousMaterialWeapon GetEntity(ModelBuilder builder)
        {
            PreciousMaterialWeapon weapon = GetWeapon();

            builder.AddSourcePage(weapon, GetSourcePage(), e => e.SourcePage);
            builder.AddTraits(weapon, GetTraits());
            builder.AddTextBlocks(weapon, GetDetails(), e => e.Details);

            foreach(PreciousMaterialWeaponVariant variant in GetVariants())
            {
                variant.WeaponId = weapon.Id;
                builder.AddData(variant);
            }

            return weapon;
        }

        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract SourcePage GetSourcePage();
        protected abstract PreciousMaterialWeapon GetWeapon();
        protected abstract IEnumerable<PreciousMaterialWeaponVariant> GetVariants();
        protected abstract IEnumerable<TextBlock> GetDetails();
    }
}
