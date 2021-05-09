﻿using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCategories.Instances
{
    public class Talismans : AbstractItemCategoryTemplate
    {
        public static readonly Guid ID = Guid.Parse("559392e9-b613-46bd-87d8-e7f74a6c5d56");

        protected override ItemCategory GetItemCategory()
        {
            return new ItemCategory 
            {
                Id = ID, 
                PageNumber = 565, 
                Name = "Talismans", 
                Description = "Consumables that are affixed to items and then activated for a one-time combat or physical benefit." 
            };
        }
    }
}