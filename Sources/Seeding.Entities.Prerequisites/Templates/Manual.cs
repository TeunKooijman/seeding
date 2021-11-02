using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class Manual : BaseModel
    {
        public string Text { get; }

        public Manual(string text)
        {
            Text = text;
        }
    }
}