using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Rarities.Instances
{
    public class Rare : Template
    {
        public static readonly Guid ID = Guid.Parse("863d10bd-583b-41e9-ae52-2d94cf0a2bff");

        protected override Rarity GetRaceRarity()
        {
            return new Rarity
            {
                Id = ID,
                Name = "Rare"
            };
        }
    }
}
