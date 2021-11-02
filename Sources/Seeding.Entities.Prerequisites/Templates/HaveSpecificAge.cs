using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificAge : BaseModel
    {
        public string ComparatorName { get; }
        public int Years { get; }

        public HaveSpecificAge(string comparatorName, int years)
        {
            ComparatorName = comparatorName;
            Years = years;
        }
    }
}