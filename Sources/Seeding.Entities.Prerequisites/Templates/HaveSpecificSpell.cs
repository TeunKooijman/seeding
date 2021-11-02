using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificSpell : BaseModel
    {
        public string RequiredSpellName { get; }

        public HaveSpecificSpell(string requiredSpellName)
        {
            RequiredSpellName = requiredSpellName;
        }
    }
}