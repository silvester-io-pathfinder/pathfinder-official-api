﻿using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class AlchemicalPoison : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Usage { get; set; } = default!;
        
        public int ItemLevel { get; set; }

        public int Price { get; set; }

        public Guid ActionTypeId { get; set; }
        public ActionType ActionType { get; set; } = default!;

        public Guid BulkId { get; set; }
        public Bulk Bulk { get; set; } = default!;

        public Guid ActionId { get; set; }
        public Action Action { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid EffectId { get; set; }
        public StaggeredEffect Effect { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
    }
}