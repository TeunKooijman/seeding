using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificStanceAmount : BaseModel
    {
        public string ComparatorName { get; }
        public int Amount { get; }

        public HaveSpecificStanceAmount(string comparatorName, int amount)
        {
            ComparatorName = comparatorName;
            Amount = amount;
        }
    }
}