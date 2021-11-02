using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class FollowSpecificPhilosophy : BaseModel
    {
        public string RequiredPhilosphyName { get; }

        public FollowSpecificPhilosophy(string requiredPhilosphyName)
        {
            RequiredPhilosphyName = requiredPhilosphyName;
        }
    }
}