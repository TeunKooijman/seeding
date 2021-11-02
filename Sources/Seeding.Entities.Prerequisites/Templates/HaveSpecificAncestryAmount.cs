using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificAncestryAmount : BaseModel
    {
        public string ComparatorName { get; }
        public int Amount { get; }

        public HaveSpecificAncestryAmount(string comparatorName, int amount)
        {
            ComparatorName = comparatorName;
            Amount = amount;
        }
    }
}