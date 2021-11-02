using Seeding.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Transforming
{
    public interface ITextBlockTransformer
    {
        IEnumerable<TextBlockModel> Transform(string description);
    }

    public class TextBlockTransformer : ITextBlockTransformer
    {
        public IEnumerable<TextBlockModel> Transform(string description)
        {
            foreach(string line in description.Split("\r\n"))
            {
                if(line.StartsWith("*"))
                {
                    yield return new TextBlockModel { Text = line.Substring("*".Length), Type = "Enumeration" };
                }
                else
                {
                    yield return new TextBlockModel { Text = line, Type = "Text" };
                }
            }
        }
    }
}
