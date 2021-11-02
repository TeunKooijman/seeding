using Seeding.Feats.Models;
using Seeding.Feats.Parsers;
using Seeding.Feats.Transformers;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Feats
{
    public class FeatSeeder
    {
        private IFeatParser Parser { get; }
        private IMustacheTemplater Templater { get; }
        private IFeatTransformer Transformer { get; }

        public FeatSeeder(IFeatParser parser, IMustacheTemplater templater, IFeatTransformer transformer)
        {
            Parser = parser;
            Templater = templater;
            Transformer = transformer;
        }

        public async Task Seed(string csvPath)
        {
            string template = await File.ReadAllTextAsync(Path.Combine(Directory.GetCurrentDirectory(), "Templates", "feat.mustache"));

            foreach(WanderersGuideFeatModel feat in Parser.Parse(File.OpenRead(csvPath)))
            {
                if(feat.SkillId != null)
                {
                    //We skip skill feats, as they are different entities in PF2E.io (SkillAction).
                    continue;
                }

                TemplateFeatModel model = Transformer.Transform(feat);
                await Templater.RenderTemplateAsync(template, model);
            }
        }
    }

}
