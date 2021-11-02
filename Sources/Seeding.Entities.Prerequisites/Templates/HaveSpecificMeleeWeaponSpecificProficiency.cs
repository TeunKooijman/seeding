using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificMeleeWeaponSpecificProficiency : BaseModel
    {
        public string RequiredProficiencyName { get; }
        public string RequiredMeleeWeaponName { get; }

        public HaveSpecificMeleeWeaponSpecificProficiency(string requiredProficiencyName, string requiredMeleeWeaponName)
        {
            RequiredProficiencyName = requiredProficiencyName;
            RequiredMeleeWeaponName = requiredMeleeWeaponName;
        }
    }
}