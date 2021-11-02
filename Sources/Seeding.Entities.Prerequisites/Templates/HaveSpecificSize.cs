using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificSize : BaseModel
    {
        public string RequiredSizeName { get; }

        public HaveSpecificSize(string requiredSizeName)
        {
            RequiredSizeName = requiredSizeName;
        }
    }
}