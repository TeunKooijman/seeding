using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveAnyWeaponCategorySpecificProficiency : BaseModel
    {
        public string RequiredProficiencyName { get; }

        public HaveAnyWeaponCategorySpecificProficiency(string requiredProficiencyName)
        {
            RequiredProficiencyName = requiredProficiencyName;
        }
    }
}