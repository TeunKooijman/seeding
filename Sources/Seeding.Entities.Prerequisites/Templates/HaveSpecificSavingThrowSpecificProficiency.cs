using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificSavingThrowSpecificProficiency : BaseModel
    {
        public string RequiredProficiencyName { get; }
        public string RequiredSavingThrowStatName { get; }

        public HaveSpecificSavingThrowSpecificProficiency(string requiredProficiencyName, string requiredSavingThrowStatName)
        {
            RequiredProficiencyName = requiredProficiencyName;
            RequiredSavingThrowStatName = requiredSavingThrowStatName;
        }
    }
}