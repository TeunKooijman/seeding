using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificDivineAlly : BaseModel
    {
        public string RequiredDivineAllyName { get; }

        public HaveSpecificDivineAlly(string requiredDivineAllyName)
        {
            RequiredDivineAllyName = requiredDivineAllyName;
        }
    }
}