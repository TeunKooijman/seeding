using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificBloodlineTradition : BaseModel
    {
        public string RequiredBloodineMagicTraditionName { get; }

        public HaveSpecificBloodlineTradition(string requiredBloodineMagicTraditionName)
        {
            RequiredBloodineMagicTraditionName = requiredBloodineMagicTraditionName;
        }
    }
}