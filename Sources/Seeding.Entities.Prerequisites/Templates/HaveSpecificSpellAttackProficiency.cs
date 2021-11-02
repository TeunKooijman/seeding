using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificSpellAttackProficiency : BaseModel
    {
        public string RequiredProficiencyName { get; }

        public HaveSpecificSpellAttackProficiency(string requiredProficiencyName)
        {
            RequiredProficiencyName = requiredProficiencyName;
        }
    }
}