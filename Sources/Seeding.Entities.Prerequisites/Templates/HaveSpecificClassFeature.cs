using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificClassFeature : BaseModel
    {
        public string RequiredClassFeatureName{ get; }
        public string PluralClassName { get; }

        public HaveSpecificClassFeature(string requiredClassFeatureName, string pluralClassName)
        {
            RequiredClassFeatureName = requiredClassFeatureName;
            PluralClassName = pluralClassName;
        }
    }
}