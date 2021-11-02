using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificGunslingersWay : BaseModel
    {
        public string RequiredGunslingersWayName { get; }

        public HaveSpecificGunslingersWay(string requiredGunslingersWayName)
        {
            RequiredGunslingersWayName = requiredGunslingersWayName;
        }
    }
}