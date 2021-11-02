using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificDecipherWritingProficiency : BaseModel
    {
        public string RequiredProficiencyName { get; }

        public HaveSpecificDecipherWritingProficiency(string requiredProficiencyName)
        {
            RequiredProficiencyName = requiredProficiencyName;
        }
    }
}