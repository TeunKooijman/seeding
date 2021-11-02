using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificAlignment : BaseModel
    {
        public string RequiredAlignmentName { get; }

        public HaveSpecificAlignment(string requiredAlignmentName)
        {
            RequiredAlignmentName = requiredAlignmentName;
        }
    }
}