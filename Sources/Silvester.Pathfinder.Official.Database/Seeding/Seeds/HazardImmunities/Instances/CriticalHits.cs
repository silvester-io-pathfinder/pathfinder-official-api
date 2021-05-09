﻿using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.HazardImmunities.Instances
{
    public class CriticalHits : AbstractHazardImmunityTemplate
    {
        public static readonly Guid ID = Guid.Parse("7bbfc8dc-05c1-49f6-938d-07eb81d7ad83");

        protected override HazardImmunity GetHazardImmunity()
        {
            return new HazardImmunity 
            {
                Id = ID, 
                Name = "Critical Hits" 
            };
        }
    }
}