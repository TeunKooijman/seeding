using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificTenet : BaseModel
    {
        public string RequiredTenetName { get; }

        public HaveSpecificTenet(string requiredTenetName)
        {
            RequiredTenetName = requiredTenetName;
        }
    }
}