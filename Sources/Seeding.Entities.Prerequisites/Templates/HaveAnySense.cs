using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveAnySense : BaseModel
    {
        public string RequiredSenseAccuracyName { get; }

        public HaveAnySense(string requiredSenseAccuracyName)
        {
            RequiredSenseAccuracyName = requiredSenseAccuracyName;
        }
    }
}