using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.SpellComponents
{
    public abstract class Template : EntityTemplate<SpellComponent>
    {
        protected override SpellComponent GetEntity(ModelBuilder builder)
        {
            SpellComponent component = GetSpellComponent();
            return component;
        }

        public abstract SpellComponent GetSpellComponent();
    }
}
