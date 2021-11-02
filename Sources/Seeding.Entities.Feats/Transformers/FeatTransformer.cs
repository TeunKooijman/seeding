using Seeding.Feats.Models;
using Seeding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transforming;
using Translating;

namespace Seeding.Feats.Transformers
{
    public interface IFeatTransformer
    {
        TemplateFeatModel Transform(WanderersGuideFeatModel input);
    }

    public class FeatTransformer : IFeatTransformer
    {
        private INameTranslator NameTranslator { get; }
        private IActionTypeTranslator ActionTypeTranslator { get; }
        private ISourceTranslator SourceTranslator { get; }
        private IRollableEffectTransformer RollableEffectTransformer { get; }
        private ITextBlockTransformer TextBlockTransformer { get; }

        public FeatTransformer(INameTranslator nameTranslator, IActionTypeTranslator actionTypeTranslator, ISourceTranslator sourceTranslator, IRollableEffectTransformer rollableEffectTransformer, ITextBlockTransformer textBlockTransformer)
        {
            NameTranslator = nameTranslator;
            ActionTypeTranslator = actionTypeTranslator;
            SourceTranslator = sourceTranslator;
            RollableEffectTransformer = rollableEffectTransformer;
            TextBlockTransformer = textBlockTransformer;
        }

        public TemplateFeatModel Transform(WanderersGuideFeatModel input)
        {
            IRollableEffectTransformer.TransformationResult description = RollableEffectTransformer.Transform(input.Description);

            return new TemplateFeatModel
            {
                ClassName = NameTranslator.ToClassName(input.Name)!,
                FeatName = input.Name,
                Level = input.Level,
                ActionType = ActionTypeTranslator.ToActionTypeInstanceName(input.Action)!,
                CanBeLearnedMoreThanOnce = input.CanSelectMultiple ?? false,
                Special = input.Special,
                Trigger = input.Trigger,
                Frequency = input.Frequency,
                Source = SourceTranslator.ToSourceInstanceName(input.ContentSource)!,
                Page = -1,
                RollableEffect = description.RollableEffect,
                Details = TextBlockTransformer.Transform(description.DescriptionRemainder).ToArray(),
                Prerequisites = 
            };
        }
    }
}
