using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.MagicSchools
{
    public abstract class Template : EntityTemplate<MagicSchool>
    {
        protected override MagicSchool GetEntity(ModelBuilder builder)
        {
            MagicSchool school = GetMagicSchool();
            return school;
        }

        protected abstract MagicSchool GetMagicSchool();
    }
}
