using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificInstinct : BaseModel
    {
        public string RequiredInstinctName { get; }

        public HaveSpecificInstinct(string requiredInstinctName)
        {
            RequiredInstinctName = requiredInstinctName;
        }
    }
}