using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificHeritage : BaseModel
    {
        public string RequiredHeritageName { get; }

        public HaveSpecificHeritage(string requiredHeritageName)
        {
            RequiredHeritageName = requiredHeritageName;
        }
    }
}