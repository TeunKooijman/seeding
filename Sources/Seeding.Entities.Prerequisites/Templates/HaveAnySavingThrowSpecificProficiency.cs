using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveAnySavingThrowSpecificProficiency : BaseModel
    {
        public string RequiredProficiencyName { get; }

        public HaveAnySavingThrowSpecificProficiency(string requiredProficiencyName)
        {
            RequiredProficiencyName = requiredProficiencyName;
        }
    }
}