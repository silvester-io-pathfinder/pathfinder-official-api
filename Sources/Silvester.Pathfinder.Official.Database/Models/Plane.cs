using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Plane : BaseEntity
    {
        public string Name { get; set; } = default!;

        public Guid CategoryId { get; set; }
        public PlaneCategory Category { get; set; } = default!;

        public Guid AlignmentId { get; set; }
        public Alignment Alignment { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
    }
}
