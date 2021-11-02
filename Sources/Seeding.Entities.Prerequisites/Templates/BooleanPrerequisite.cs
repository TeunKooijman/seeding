using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class BooleanPrerequisite : BaseModel
    {
        public ITemplate<BaseModel>[] Templates{ get; }
        public bool IsOrOperation { get; }
        public bool IsAndOperation { get; }

        public static BooleanPrerequisite And(IMustacheTemplater templater, params BaseModel[] templates)
        {
            return new BooleanPrerequisite(templater, BooleanOperator.And, templates);
        }

        public static BooleanPrerequisite Or(IMustacheTemplater templater, params BaseModel[] templates)
        {
            return new BooleanPrerequisite(templater, BooleanOperator.Or, templates);
        }

        public BooleanPrerequisite(IMustacheTemplater templater, BooleanOperator @operator, params BaseModel[] templates)
        { 
            Templates = templates
                .Select(e => new Template<BaseModel>(templater, e))
                .ToArray();

            IsOrOperation = @operator == BooleanOperator.Or;
            IsAndOperation = @operator == BooleanOperator.And;

            foreach(ITemplate<BaseModel> template in Templates)
            {
                template.Model.BuilderParameterName = @operator switch
                {
                    BooleanOperator.And => "and",
                    BooleanOperator.Or => "or",
                    _ => throw new InvalidOperationException()
                };
            }
        }

        public enum BooleanOperator
        {
            And,
            Or
        }
    }
}