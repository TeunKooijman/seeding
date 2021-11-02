using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificCause : BaseModel
    {
        public string RequiredCauseName { get; }

        public HaveSpecificCause(string requiredCauseName)
        {
            RequiredCauseName = requiredCauseName;
        }
    }
}