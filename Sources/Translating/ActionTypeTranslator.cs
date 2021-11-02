using Extensions;
using System;
using System.Linq;

namespace Translating
{
    public interface IActionTypeTranslator
    {
        string? ToActionTypeInstanceName(string? input);
    }

    public class ActionTypeTranslator : IActionTypeTranslator
    {
        public string? ToActionTypeInstanceName(string? input)
        {
            return input switch
            {
                null => null,
                "" => null,
                "NONE" => "NoAction",
                "REACTION" => "Reaction",
                "ACTION" => "OneAction",
                "TWO_ACTIONS" => "TwoActions",
                "THREE_ACTIONS" => "ThreeActions",
                "FREE_ACTION" => "FreeAction",
                _ => throw new NotSupportedException($"The action type '{input}' is not supported.")
            };
        }
    }
}
