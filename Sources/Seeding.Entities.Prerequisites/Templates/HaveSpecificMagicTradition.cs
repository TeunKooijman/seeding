using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificMagicTradition : BaseModel
    {
        public string RequiredMagicTraditionName { get; }

        public HaveSpecificMagicTradition(string requiredMagicTraditionName)
        {
            RequiredMagicTraditionName = requiredMagicTraditionName;
        }
    }
}