using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificMuse : BaseModel
    {
        public string RequiredMuseName{ get; }

        public HaveSpecificMuse(string requiredMuseName)
        {
            RequiredMuseName = requiredMuseName;
        }
    }
}