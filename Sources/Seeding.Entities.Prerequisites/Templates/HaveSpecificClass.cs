using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificClass : BaseModel
    {
        public string RequiredClassName { get; }

        public HaveSpecificClass(string requiredClassName)
        {
            RequiredClassName = requiredClassName;
        }
    }
}