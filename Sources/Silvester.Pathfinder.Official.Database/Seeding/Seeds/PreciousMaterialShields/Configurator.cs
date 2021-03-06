using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialShields
{
    public class SearchConfigurator : SearchableEntityConfigurator<PreciousMaterialShield>
    {
        public override Expression<Func<PreciousMaterialShield, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
