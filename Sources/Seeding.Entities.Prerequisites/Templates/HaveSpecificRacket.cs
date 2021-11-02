using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificRacket : BaseModel
    {
        public string RequiredRacketName { get; }

        public HaveSpecificRacket(string requiredRacketName)
        {
            RequiredRacketName = requiredRacketName;
        }
    }
}