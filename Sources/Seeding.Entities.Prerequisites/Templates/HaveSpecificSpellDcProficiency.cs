using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificSpellDcProficiency : BaseModel
    {
        public string RequiredProficiencyName { get; }

        public HaveSpecificSpellDcProficiency(string requiredProficiencyName)
        {
            RequiredProficiencyName = requiredProficiencyName;
        }
    }
}