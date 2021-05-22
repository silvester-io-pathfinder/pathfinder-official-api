using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Rarity : BaseEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Race> Races { get; set; } = new List<Race>();
    }
}
