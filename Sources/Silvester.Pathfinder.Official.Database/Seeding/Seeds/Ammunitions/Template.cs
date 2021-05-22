﻿using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System.Collections.Generic;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Ammunitions
{
    public abstract class Template : EntityTemplate<Ammunition>
    {
        protected override Ammunition GetEntity(ModelBuilder builder)
        {
            Ammunition ammunition = GetAmmunition();

            builder.AddSourcePage(ammunition, GetSourcePage(), e => e.SourcePage);

            return ammunition;
        }

        protected abstract SourcePage GetSourcePage();
        protected abstract Ammunition GetAmmunition();
    }
}
