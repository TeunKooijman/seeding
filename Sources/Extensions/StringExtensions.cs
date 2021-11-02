using System;
using System.Linq;
using System.Text;

namespace Extensions
{
    public static class StringExtensions
    {
        public static string Capitalize(this string input)
        {
            return char.ToUpper(input[0]) + input.Substring(1);
        }

        public static string Sanitize(this string input, params char[] charactersToRemove)
        {
            StringBuilder builder = new StringBuilder();
            foreach(char current in input.Where(current => charactersToRemove.Contains(current) == false))
            {
                builder.Append(current);
            }

            return builder.ToString();
        }
    }
}
