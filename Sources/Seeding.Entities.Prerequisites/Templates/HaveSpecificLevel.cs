using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificLevel : BaseModel
    {
        public string ComparatorName { get; }
        public int Level { get; }

        public HaveSpecificLevel(string comparatorName, int level)
        {
            ComparatorName = comparatorName;
            Level = level;
        }
    }
}