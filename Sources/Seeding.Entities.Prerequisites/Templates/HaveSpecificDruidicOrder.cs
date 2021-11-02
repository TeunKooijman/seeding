using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificDruidicOrder : BaseModel
    {
        public string RequiredDruidicOrderName { get; }

        public HaveSpecificDruidicOrder(string requiredDruidicOrderName)
        {
            RequiredDruidicOrderName = requiredDruidicOrderName;
        }
    }
}