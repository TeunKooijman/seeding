using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificMovementMethod : BaseModel
    {
        public string RequiredMovementMethodName { get; }

        public HaveSpecificMovementMethod(string requiredMovementMethod)
        {
            RequiredMovementMethodName = requiredMovementMethod;
        }
    }
}