using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveAnyArmorCategorySpecificProficiency : BaseModel
    {
        public string RequiredProficiencyName { get; }

        public HaveAnyArmorCategorySpecificProficiency(string requiredProficiencyName)
        {
            RequiredProficiencyName = requiredProficiencyName;
        }
    }
}