using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificLanguage : BaseModel
    {
        public string RequiredLanguageName { get; }

        public HaveSpecificLanguage(string requiredLanguageName)
        {
            RequiredLanguageName = requiredLanguageName;
        }
    }
}