using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveAnyMeleeWeaponSpecificProficiency : BaseModel
    {
        public string RequiredProficiencyName { get; }

        public HaveAnyMeleeWeaponSpecificProficiency(string requiredProficiencyName)
        {
            RequiredProficiencyName = requiredProficiencyName;
        }
    }
}