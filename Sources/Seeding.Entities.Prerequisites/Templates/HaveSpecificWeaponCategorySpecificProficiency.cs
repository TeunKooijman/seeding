using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificWeaponCategorySpecificProficiency : BaseModel
    {
        public string RequiredProficiencyName{ get; }
        public string RequiredWeaponCategoryName { get; }

        public HaveSpecificWeaponCategorySpecificProficiency(string requiredProficiencyName, string requiredWeaponCategoryName)
        {
            RequiredProficiencyName = requiredProficiencyName;
            RequiredWeaponCategoryName = requiredWeaponCategoryName;
        }
    }
}