using System;

namespace Seeding.Entities.Prerequisites.Templates
{
    public abstract class BaseModel
    {
        public Guid GenerateId => Guid.NewGuid();
        public string BuilderParameterName { get; set; }

        public static implicit operator BaseModel[] (BaseModel model) => new BaseModel[] { model };
    }
}