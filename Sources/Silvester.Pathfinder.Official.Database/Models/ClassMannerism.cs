using System;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class ClassMannerism : BaseEntity
    {
        public string Text { get; set; } = default!;

        public Guid ClassId { get; set; }
        public Class Class { get; set; } = default!;
    }
}
