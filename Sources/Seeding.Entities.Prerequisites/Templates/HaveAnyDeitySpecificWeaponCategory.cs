using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveAnyDeitySpecificWeaponCategory : BaseModel
    {
        public string RequiredWeaponCategoryName { get; }

        public HaveAnyDeitySpecificWeaponCategory(string requiredWeaponCategoryName)
        {
            RequiredWeaponCategoryName = requiredWeaponCategoryName;
        }
    }
}