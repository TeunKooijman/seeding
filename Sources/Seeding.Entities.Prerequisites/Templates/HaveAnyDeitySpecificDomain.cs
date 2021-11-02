using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveAnyDeitySpecificDomain : BaseModel
    {
        public string RequiredDomainName { get; }

        public HaveAnyDeitySpecificDomain(string requiredDomainName)
        {
            RequiredDomainName = requiredDomainName;
        }
    }
}