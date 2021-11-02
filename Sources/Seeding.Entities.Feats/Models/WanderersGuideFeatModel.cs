namespace Seeding.Feats.Models
{
    public class WanderersGuideFeatModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Action { get; set; } = default!;
        public int Level { get; set; }
        public string Rarity { get; set; } = default!;
        public string? Prerequisite { get; set; } 
        public string? Frequency { get; set; }
        public string? Cost { get; set; }
        public string? Trigger { get; set; }
        public string? Requirements { get; set; }
        public string Description { get; set; } = default!;
        public string? Special { get; set; }
        public bool? CanSelectMultiple { get; set; }
        public bool IsDefault { get; set; }
        public string? SkillId { get; set; }
        public string? MinProficiency { get; set; }
        public string? Code { get; set; }
        public bool IsCore { get; set; }
        public string GenericType { get; set; } = default!;
        public string? GenTypeName { get; set; }
        public bool IsArchived { get; set; }
        public string ContentSource { get; set; } = default!;
        public string? Homebrew { get; set; }
        public int Version { get; set; }
    }
}
