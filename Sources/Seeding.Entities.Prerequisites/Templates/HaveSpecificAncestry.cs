using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificAncestry : BaseModel
    {
        public string RequiredAncestryName { get; }

        public HaveSpecificAncestry(string requiredAncestryName)
        {
            RequiredAncestryName = requiredAncestryName;
        }
    }
}