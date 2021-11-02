namespace Seeding.Models
{
    public class RollableEffectModel
    {
        public bool HasCriticalSuccess => string.IsNullOrWhiteSpace(CriticalSuccess) == false;
        public string? CriticalSuccess { get; set; }

        public bool HasSuccess => string.IsNullOrWhiteSpace(Success) == false;
        public string? Success { get; set; }

        public bool HasFailure => string.IsNullOrWhiteSpace(Failure) == false;
        public string? Failure { get; set; }

        public bool HasCriticalFailure => string.IsNullOrWhiteSpace(CriticalFailure) == false;
        public string? CriticalFailure { get; set; }

        public bool HasAny => HasCriticalSuccess || HasSuccess || HasFailure || HasCriticalFailure;
    }
}
