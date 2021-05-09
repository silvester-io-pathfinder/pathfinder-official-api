﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponGroups.Instances
{
    public class Hammer : AbstractWeaponGroupTemplate
    {
        public static readonly Guid ID = Guid.Parse("3abdc611-2ead-4444-bc8f-68058807c060");

        protected override WeaponGroup GetWeaponGroup()
        {
            return new WeaponGroup
            {
                Id = ID,
                Name = "Hammer",
                CriticalEffect = "The target is knocked prone."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d426a649-6cb7-4fa1-b1ca-4d0488bbe704"),
                SourceId = CoreRulebook.ID,
                Page = 284
            };
        }
    }
}