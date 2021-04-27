﻿using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.LanguageTypes.Instances
{
    public class Sign : AbstractLanguageTypeTemplate
    {
        public static readonly Guid ID = Guid.Parse("705b76de-5a42-4e7b-aaf2-16feb7b232d0");

        protected override LanguageType GetLanguageType()
        {
            return new LanguageType 
            {
                Id = ID, 
                Name = "Sign" 
            };
        }
    }
}
