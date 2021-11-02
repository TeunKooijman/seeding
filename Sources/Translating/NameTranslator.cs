using Extensions;
using System;
using System.Linq;

namespace Translating
{
    public interface INameTranslator
    {
        string? ToClassName(string? input);
    }

    public class NameTranslator : INameTranslator
    {
        public string? ToClassName(string? input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            string[] words = input
                .Split(" ")
                .SelectMany(e => e.Split("-"))
                .Select(e => e.Capitalize())
                .Select(e => e.Sanitize('\'', '"', '`', '?', '&', '^', '#', '@', '!', '(', ')', '+', '-', ',', ':', ';', '<', '>', '’', '_', '*'))
                .ToArray();

            return string.Join("", words);
        }
    }
}
