using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificAnimalCompanionAmount : BaseModel
    {
        public string ComparatorName { get; set; }
        public int Amount { get; set; }

        public HaveSpecificAnimalCompanionAmount(string comparatorName, int amount)
        {
            ComparatorName = comparatorName;
            Amount = amount;
        }
    }
}