using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveAnyDeitySpecificFont : BaseModel
    {
        public string RequiredDivineFontName { get; }

        public HaveAnyDeitySpecificFont(string requiredDivineFontName)
        {
            RequiredDivineFontName = requiredDivineFontName;
        }
    }
}