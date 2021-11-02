using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificDeity : BaseModel
    {
        public string RequiredDeityName { get; }

        public HaveSpecificDeity(string requiredDeityName)
        {
            RequiredDeityName = requiredDeityName;
        }
    }
}