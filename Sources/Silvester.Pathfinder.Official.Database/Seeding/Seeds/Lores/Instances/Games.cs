﻿using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores.Instances
{
    public class Games : AbstractLoreTemplate
    {
        public static readonly Guid ID = Guid.Parse("59c448b6-53f8-46d4-a547-d8a7ff86d334");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Games"
            };
        }
    }
}
