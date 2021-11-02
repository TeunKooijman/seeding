using System;
using System.Threading.Tasks;
using Templating;

namespace Seeding.Entities.Prerequisites.Templates
{
    public class Todo : BaseModel
    {
        public string Text { get; }

        public Todo(string text = "Add prerequisites.")
        {
            Text = text;
        }
    }
}