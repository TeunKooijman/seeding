using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificRecallKnowledge : BaseModel
    {
        public bool RequiresAssurance { get; }
        public string RequiredProficiencyName { get; }

        public HaveSpecificRecallKnowledge(string requiredProficiencyName, bool requiresAssurance)
        {
            RequiredProficiencyName = requiredProficiencyName;
            RequiresAssurance = requiresAssurance;
        }
    }
}