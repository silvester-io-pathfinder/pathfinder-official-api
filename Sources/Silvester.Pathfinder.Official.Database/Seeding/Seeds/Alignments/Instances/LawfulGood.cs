﻿using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Alignments.Instances
{
    public class LawfulGood : AbstractAlignmentTemplate
    {
        public static readonly Guid ID = Guid.Parse("2006ffe6-8a03-4d40-99ac-935d814140ec");

        protected override Alignment GetAlignment()
        {
           return new Alignment 
           {
               Id = ID, 
               Name = "Lawful Good",
               Description = "A lawful good character typically acts with compassion and always with honor and a sense of duty. However, lawful good characters will often regret taking any action they fear would violate their code, even if they recognize such action as being good." 
           };
        }
    }
}
