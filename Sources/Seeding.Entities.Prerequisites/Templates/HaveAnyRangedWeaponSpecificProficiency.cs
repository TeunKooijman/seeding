using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveAnyRangedWeaponSpecificProficiency : BaseModel
    {
        public string RequiredProficiencyName { get; }

        public HaveAnyRangedWeaponSpecificProficiency(string requiredProficiencyName)
        {
            RequiredProficiencyName = requiredProficiencyName;
        }
    }
}