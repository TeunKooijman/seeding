using Seeding.Models;
using System;
using System.Text;

namespace Transforming
{
    public interface IRollableEffectTransformer
    {
        TransformationResult Transform(string description);

        public class TransformationResult
        {
            public RollableEffectModel? RollableEffect { get; set; }
            public string DescriptionRemainder { get; set; }

            public TransformationResult(RollableEffectModel rollableEffect, string descriptionRemainder)
            {
                RollableEffect = rollableEffect.HasAny ? rollableEffect : null;
                DescriptionRemainder = descriptionRemainder;
            }
        }
    }

    public class RollableEffectTransformer : IRollableEffectTransformer
    {
        public IRollableEffectTransformer.TransformationResult Transform(string description)
        {
            StringBuilder remainder = new StringBuilder();
            RollableEffectModel effect = new RollableEffectModel();

            string[] lines = description.Split("\r\n");
            foreach (string line in lines)
            {
                if (line.StartsWith("Critical Success: "))
                {
                    effect.CriticalSuccess = line.Substring("Critical Success: ".Length);
                }
                else if (line.StartsWith("Critical Failure: "))
                {
                    effect.CriticalFailure = line.Substring("Critical Failure: ".Length);
                }
                else if (line.StartsWith("Success: "))
                {
                    effect.Success = line.Substring("Success: ".Length);
                }
                else if (line.StartsWith("Failure: "))
                {
                    effect.Failure = line.Substring("Failure: ".Length);
                }
                else
                {
                    remainder.AppendLine(line);
                }
            }

            return new IRollableEffectTransformer.TransformationResult(effect, remainder.ToString());
        }
    }
}
