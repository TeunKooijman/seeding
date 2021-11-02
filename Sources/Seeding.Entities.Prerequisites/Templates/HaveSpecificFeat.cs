using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificFeat : BaseModel
    {
        public string RequiredFeatName{ get; }

        public HaveSpecificFeat(string requiredFeatName)
        {
            RequiredFeatName = requiredFeatName;
        }
    }
}