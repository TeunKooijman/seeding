using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificMethodology : BaseModel
    {
        public string RequiredMethodologyName { get; }

        public HaveSpecificMethodology(string requiredMethodologyName)
        {
            RequiredMethodologyName = requiredMethodologyName;
        }
    }
}