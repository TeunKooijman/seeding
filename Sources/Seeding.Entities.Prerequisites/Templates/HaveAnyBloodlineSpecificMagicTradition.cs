using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveAnyBloodlineSpecificMagicTradition : BaseModel
    {
        public string RequiredMagicTraditionName { get; }

        public HaveAnyBloodlineSpecificMagicTradition(string requiredMagicTraditionName)
        {
            RequiredMagicTraditionName = requiredMagicTraditionName;
        }
    }
}