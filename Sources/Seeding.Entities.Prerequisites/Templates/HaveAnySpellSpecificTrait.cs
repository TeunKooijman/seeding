using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveAnySpellSpecificTrait : BaseModel
    {
        public string RequiredTraitName { get; }

        public HaveAnySpellSpecificTrait(string requiredTraitName)
        {
            RequiredTraitName = requiredTraitName;
        }
    }
}