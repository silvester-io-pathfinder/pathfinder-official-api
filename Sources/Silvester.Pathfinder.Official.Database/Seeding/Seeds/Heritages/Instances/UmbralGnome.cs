using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Races.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Heritages.Instances
{
    public class UmbralGnome : Template
    {
        public static readonly Guid ID = Guid.Parse("1109b6f8-33b0-4868-92f1-49e1ab8135d3");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Umbral Gnome", 
                Description = "Whether from a connection to dark or shadowy fey, from the underground deep gnomes also known as svirfneblin, or another source, you can see in complete darkness. You gain darkvision." 
            };
        }

        protected override IEnumerable<Guid> GetRaces()
        {
            yield return Gnome.ID;
        }
    }
}
