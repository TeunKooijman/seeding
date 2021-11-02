using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificBloodline : BaseModel
    {
        public string RequiredBloodlineName { get; }

        public HaveSpecificBloodline(string requiredBloodlineName)
        {
            RequiredBloodlineName = requiredBloodlineName;
        }
    }
}