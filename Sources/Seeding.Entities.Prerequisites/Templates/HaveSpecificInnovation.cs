using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificInnovation : BaseModel
    {
        public string RequiredInnovationName { get; }

        public HaveSpecificInnovation(string requiredInnovationName)
        {
            RequiredInnovationName = requiredInnovationName;
        }
    }
}