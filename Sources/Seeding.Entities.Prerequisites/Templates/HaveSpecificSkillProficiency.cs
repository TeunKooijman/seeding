using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificSkillProficiency : BaseModel
    {
        public string ProficiencyName { get; }
        public string SkillName { get; }

        public HaveSpecificSkillProficiency(string proficiencyName, string skillName)
        {
            ProficiencyName = proficiencyName;
            SkillName = skillName;
        }
    }
}