﻿using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Probes.Readiness
{
    public interface IReadinessProbe
    {
        ValueTask<bool> IsReadyToAcceptTrafficAsync();
    }

    public class DefaultReadinessProbe : IReadinessProbe
    {
        public ValueTask<bool> IsReadyToAcceptTrafficAsync()
        {
            return new ValueTask<bool>(true);
        }
    }
}
