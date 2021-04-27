﻿using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.MagicEssences.Instances
{
    public class Spirit : AbstractMagicEssenceTemplate
    {
        public static readonly Guid ID = Guid.Parse("3a378975-c527-4240-a39c-4b854bc00573");

        protected override MagicEssence GetMagicEssence()
        {
            return new MagicEssence
            {
                Id = ID,
                Name = "Spirit",
                Description = "Also called soul, ethereal essence, or spiritual essence, spirit is an otherworldly building block that makes up a being’s immaterial and immortal self. The spirit travels through the Ethereal Plane and into the Great Beyond after the death of the physical body. The spirit is most easily affected by divine and occult spells. Spirit spells are usually of the divination or necromancy schools."
            };
        }
    }
}
