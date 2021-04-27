﻿using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Proficiencies.Instances
{
    public class Trained : AbstractProficiencyTemplate
    {
        public static readonly Guid ID = Guid.Parse("130841fd-de3b-45e7-bb97-c4ded6ec71e8");

        public override Proficiency GetProficiency()
        {
            return new Proficiency
            {
                Id = ID,
                Bonus = 2,
                Name = "Trained"
            };
        }
    }
}
