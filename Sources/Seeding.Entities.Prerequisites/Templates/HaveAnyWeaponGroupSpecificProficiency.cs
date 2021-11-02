using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveAnyWeaponGroupSpecificProficiency : BaseModel
    {
        public string RequiredProficiencyName { get; }

        public HaveAnyWeaponGroupSpecificProficiency(string requiredProficiencyName)
        {
            RequiredProficiencyName = requiredProficiencyName;
        }
    }
}