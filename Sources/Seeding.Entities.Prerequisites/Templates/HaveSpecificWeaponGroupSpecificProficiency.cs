using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificWeaponGroupSpecificProficiency : BaseModel
    {
        public string RequiredProficiencyName{ get; }
        public string RequiredWeaponGroupName { get; }

        public HaveSpecificWeaponGroupSpecificProficiency(string requiredProficiencyName, string requiredWeaponGroupName)
        {
            RequiredProficiencyName = requiredProficiencyName;
            RequiredWeaponGroupName = requiredWeaponGroupName;
        }
    }
}