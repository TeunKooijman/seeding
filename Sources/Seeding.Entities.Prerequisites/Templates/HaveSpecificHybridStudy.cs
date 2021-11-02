using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificHybridStudy : BaseModel
    {
        public string RequiredHybridStudyName { get; }

        public HaveSpecificHybridStudy(string requiredHybridStudyName)
        {
            RequiredHybridStudyName = requiredHybridStudyName;
        }
    }
}