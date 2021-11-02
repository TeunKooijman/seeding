using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificDivineFont : BaseModel
    {
        public string RequiredDivineFontName { get; }

        public HaveSpecificDivineFont(string requiredDivineFontName)
        {
            RequiredDivineFontName = requiredDivineFontName;
        }
    }
}