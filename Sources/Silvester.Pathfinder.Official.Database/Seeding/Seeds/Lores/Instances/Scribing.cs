﻿using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores.Instances
{
    public class Scribing : AbstractLoreTemplate
    {
        public static readonly Guid ID = Guid.Parse("f68a7c82-36e8-4c6f-801a-30f996f67465");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Scribing"
            };
        }
    }
}
