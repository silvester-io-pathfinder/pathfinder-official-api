﻿using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.RaceSizes.Instances
{
    public class Tiny : AbstractRaceSizeTemplate
    {
        public static readonly Guid ID = Guid.Parse("f44c1295-604f-443b-9ecc-870d82264eb5");

        protected override RaceSize GetRaceSize(RaceSizeSeeder seeder)
        {
            return new RaceSize
            {
                Id = ID,
                Name = "Tiny",
                Space = 3, 
                BreadthReach = 0,
                HeightReach = 0 
            };
        }
    }
}