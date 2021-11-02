using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificArmorCategorySpecificProficiency : BaseModel
    {
        public string RequiredProficiencyName { get; }
        public string RequiredArmorCategoryName { get; }

        public HaveSpecificArmorCategorySpecificProficiency(string requiredProficiencyName, string requiredArmorCategoryName)
        {
            RequiredProficiencyName = requiredProficiencyName;
            RequiredArmorCategoryName = requiredArmorCategoryName;
        }
    }
}