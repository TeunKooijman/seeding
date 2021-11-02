using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificRecallKnowledgeProficiency : BaseModel
    {
        public bool RequiresAssurance { get; }
        public string RequiredProficiencyName { get; }

        public HaveSpecificRecallKnowledgeProficiency(string requiredProficiencyName, bool requiresAssurance)
        {
            RequiredProficiencyName = requiredProficiencyName;
            RequiresAssurance = requiresAssurance;
        }
    }
}