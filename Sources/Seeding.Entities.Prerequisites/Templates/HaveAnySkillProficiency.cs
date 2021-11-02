using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveAnySkillProficiency : BaseModel
    {
        public string ProficiencyName { get; }

        public HaveAnySkillProficiency(string proficiencyName)
        {
            ProficiencyName = proficiencyName;
        }
    }
}