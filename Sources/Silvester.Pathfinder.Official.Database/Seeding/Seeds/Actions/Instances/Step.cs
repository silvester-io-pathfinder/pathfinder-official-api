﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances
{
    public class Step : AbstractActionTemplate
    {
        public static readonly Guid ID = Guid.Parse("1e0c25df-54a1-41f0-8f21-2f6cdc08f59a");

        protected override Models.Action GetAction(ActionSeeder seeder)
        {
            return new Models.Action
            {
                Id = ID,
                Name = "Step",
                Requirements = "Your Speed is at least 10 feet.",
                ActionTypeId = seeder.GetActionType("One Action"),
            };
        }

        protected override IEnumerable<TextBlock> GetDetails(ActionSeeder seeder)
        {
            yield return new TextBlock { Id = Guid.Parse("1bf68b96-2ca3-4353-ab9a-657394acdadc"), Text = "You carefully move 5 feet. Unlike most types of movement, Stepping doesn’t trigger reactions, such as Attacks of Opportunity, that can be triggered by move actions or upon leaving or entering a square." };
            yield return new TextBlock { Id = Guid.Parse("9aea3dfc-ee32-48c0-b420-1e9ffbd3d318"), Text = "You can’t Step into difficult terrain (page 475), and you can’t Step using a Speed other than your land Speed." };
        }

        protected override IEnumerable<Trait> GetTraits(ActionSeeder seeder)
        {
            yield return seeder.GetTrait("Move");
        }
    }
}