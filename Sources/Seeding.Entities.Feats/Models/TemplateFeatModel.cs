using Seeding.Models;
using System;
using System.Collections.Generic;
using Templating;

namespace Seeding.Feats.Models
{
    public class TemplateFeatModel
    {
        public Guid GenerateGuid => Guid.NewGuid();
        public string ClassName { get; set; } = default!;
        public string FeatName { get; set; } = default!;
        public int Level { get; set; }
        public string ActionType { get; set; } = default!;
        public bool CanBeLearnedMoreThanOnce { get; set; }
        public string? Special { get; set; }
        public string? Trigger { get; set; }
        public string? Frequency { get; set; }
        public string Source { get; set; } = default!;
        public int Page { get; set; }
        
        public bool HasArchetype => string.IsNullOrEmpty(Archetype) == false;
        public string? Archetype { get; set; }

        public bool HasRollableEffect => RollableEffect != null && (RollableEffect.HasCriticalFailure || RollableEffect.HasFailure || RollableEffect.HasSuccess || RollableEffect.HasCriticalSuccess);
        public RollableEffectModel? RollableEffect { get; set; }

        public IEnumerable<TextBlockModel> Details { get; set; } = default!;
        public IEnumerable<TraitModel> Traits { get; set; } = default!;

        public IEnumerable<Template> Prerequisites { get; set; } = default!;
    }
}
