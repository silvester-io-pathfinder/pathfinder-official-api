﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Stats.Instances;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Skills.Instances
{
    public class Crafting : AbstractSkillTemplate
    {
        public static readonly Guid ID = Guid.Parse("bef3fdab-348a-4024-9095-1ab69ded3fed");

        public override Skill GetSkill()
        {
            return new Skill
            {
                Id = ID,
                Name = "Crafting",
                HasArmorCheckPenalty = false,
                HasRecallKnowledgeAction = true,
                StatModifierId = Intelligence.ID,
                Description = "You can use this skill to create and repair items. Even if you’re untrained, you can Recall Knowledge (page 238)."
            };
        }
    }
}
