using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveFavoredWeaponSpecificProficiency : BaseModel
    {
        public string RequiredProficiencyName { get; }

        public HaveFavoredWeaponSpecificProficiency(string requiredProficiencyName)
        {
            RequiredProficiencyName = requiredProficiencyName;
        }
    }
}