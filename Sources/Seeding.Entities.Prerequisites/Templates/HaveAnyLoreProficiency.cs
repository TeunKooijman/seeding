using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveAnyLoreProficiency : BaseModel
    {
        public string RequiredProficiencyName{ get; }

        public HaveAnyLoreProficiency(string requiredProficiencyName)
        {
            RequiredProficiencyName = requiredProficiencyName;
        }
    }
}