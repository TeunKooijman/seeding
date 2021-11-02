using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveAnySkillSpecificProficiency : BaseModel
    {
        public string RequiredProficiencyName { get; }

        public HaveAnySkillSpecificProficiency(string requiredProficiencyName)
        {
            RequiredProficiencyName = requiredProficiencyName;
        }
    }
}