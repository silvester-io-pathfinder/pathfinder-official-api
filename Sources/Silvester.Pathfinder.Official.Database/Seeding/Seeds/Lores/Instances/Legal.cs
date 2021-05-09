﻿using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores.Instances
{
    public class Legal : AbstractLoreTemplate
    {
        public static readonly Guid ID = Guid.Parse("10fcb507-86b4-41f1-af02-72944da5eec4");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Legal"
            };
        }
    }
}