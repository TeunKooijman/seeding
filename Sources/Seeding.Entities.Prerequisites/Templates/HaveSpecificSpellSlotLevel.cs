using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificSpellSlotLevel : BaseModel
    {
        public int SpellSlotLevel { get; }

        public HaveSpecificSpellSlotLevel(int spellSlotLevel)
        {
            SpellSlotLevel = spellSlotLevel;
        }
    }
}