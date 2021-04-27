﻿namespace Silvester.Pathfinder.Official.Database.Models
{
    public interface IRollableEffect
    {
        public string? CriticalSuccess { get; set; }

        public string? Success { get; set; }

        public string? Failure { get; set; }

        public string? CriticalFailure { get; set; }
    }

    public class RollableEffect : BaseEntity, IRollableEffect
    {
        public string? CriticalSuccess { get; set; }

        public string? Success { get; set; } 

        public string? Failure { get; set; } 

        public string? CriticalFailure { get; set; }
    }
}
