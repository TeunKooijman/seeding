using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificLanguageAmount : BaseModel
    {
        public string ComparatorName { get; }
        public int RequiredAmount { get; }

        public HaveSpecificLanguageAmount(string comparatorName, int requiredAmount)
        {
            ComparatorName = comparatorName;
            RequiredAmount = requiredAmount;
        }
    }
}