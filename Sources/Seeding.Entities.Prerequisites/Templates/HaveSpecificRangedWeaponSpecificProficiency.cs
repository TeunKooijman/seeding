using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificRangedWeaponSpecificProficiency : BaseModel
    {
        public string RequiredProficiencyName { get; }
        public string RequiredRangedWeaponName { get; }

        public HaveSpecificRangedWeaponSpecificProficiency(string requiredProficiencyName, string requiredRangedWeaponName)
        {
            RequiredProficiencyName = requiredProficiencyName;
            RequiredRangedWeaponName = requiredRangedWeaponName;
        }
    }
}