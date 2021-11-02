using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveAnyDeitySpecificAlignment : BaseModel
    {
        public string RequiredAlignmentName { get; }

        public HaveAnyDeitySpecificAlignment(string requiredAlignmentName)
        {
            RequiredAlignmentName = requiredAlignmentName;
        }
    }
}