using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificLoreSpecificProficiency : BaseModel
    {
        public string RequiredProficiencyName { get; }
        public string RequiredLoreName { get; }

        public HaveSpecificLoreSpecificProficiency(string requiredProficiencyName, string requiredLoreName)
        {
            RequiredProficiencyName = requiredProficiencyName;
            RequiredLoreName = requiredLoreName;
        }
    }
}