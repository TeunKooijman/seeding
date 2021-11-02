using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificStat : BaseModel
    {
        public int RequiredStatValue { get; }
        public string RequiredStatName{ get; }

        public HaveSpecificStat(int requiredStatValue, string requiredStatName)
        {
            RequiredStatValue = requiredStatValue;
            RequiredStatName = requiredStatName;
        }
    }
}