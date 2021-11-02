using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class WorshipSpecificDeity : BaseModel
    {
        public string RequiredDeityName { get; }
        public bool IsNegated { get; }

        public WorshipSpecificDeity(string requiredDeityName, bool isNegated = false)
        {
            RequiredDeityName = requiredDeityName;
            IsNegated = isNegated;
        }
    }
}