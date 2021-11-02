using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class HaveSpecificUnarmedAttack : BaseModel
    {
        public string RequiredUnarmedAttackName { get; }

        public HaveSpecificUnarmedAttack(string requiredUnarmedAttackName)
        {
            RequiredUnarmedAttackName = requiredUnarmedAttackName;
        }
    }
}