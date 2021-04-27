﻿using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Hallit : AbstractLanguageTemplate
    {
        public static readonly Guid ID = Guid.Parse("96b1db15-ad82-4a43-a5ad-a147d3611b4e");

        protected override Language GetLanguage()
        {
            return new Language 
            {
                Id = ID, 
                TypeId = LanguageTypes.Instances.Regional.ID, 
                Name = "Hallit" 
            };
        }
    }
}
