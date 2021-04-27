﻿using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Lores.Instances
{
    public class Heraldry : AbstractLoreTemplate
    {
        public static readonly Guid ID = Guid.Parse("2c700b95-816a-49a5-ac14-4d00798f1c66");

        protected override Lore GetLore()
        {
            return new Lore
            {
                Id = ID,
                StatModifierId = Stats.Instances.Intelligence.ID,
                Name = "Heraldry"
            };
        }
    }
}
