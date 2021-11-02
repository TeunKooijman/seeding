using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificSense : BaseModel
    {
        public string RequiredSenseName { get; }
        public string SenseAccuracyName { get; }

        public HaveSpecificSense(string requiredSenseName, string senseAccuracyName)
        {
            RequiredSenseName = requiredSenseName;
            SenseAccuracyName = senseAccuracyName;
        }
    }
}