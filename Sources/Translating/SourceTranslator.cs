using Extensions;
using System;
using System.Linq;

namespace Translating
{
    public interface ISourceTranslator
    {
        string? ToSourceInstanceName(string? input);
    }

    public class SourceTranslator : ISourceTranslator
    {
        public string? ToSourceInstanceName(string? input)
        {
            return input switch
            {
                null => null,
                "" => null,
                "ABOMINATION-VAULTS" => "AbominationVaults",
                "ADV-PLAYER-GUIDE" => "AdvancedPlayersGuide",
                "AGENTS-OF-EDGEWATCH" => "AgentsOfEdgewatch",
                "AGE-OF-ASHES" => "AgeOfAshes",
                "CRB" => "CoreRulebook",
                "DARK-ARCHIVE" => "DarkArchive",
                "EXTINCTION-CURSE" => "ExtinctionCurse",
                "FALL-OF-PLAGUE" => "FallOfPlaguestone",
                "FIST-PHOENIX" => "FistOfTheRubyPhoenix",
                "GUNS-AND-GEARS" => "GunsAndGears",
                "LOST-ANCESTRY-GUIDE" => "LostOmensAncestryGuide",
                "LOST-CHAR-GUIDE" => "LostOmensCharacterGuide",
                "LOST-GOD-MAGIC" => "LostOmensGodsAndMagic",
                "LOST-LEGENDS" => "LostOmensLegends",
                "LOST-MWANGI" => "LostOmensMwangiExpanse",
                "LOST-SOCIETY-GUIDE" => "LostOmensSocietyGuide",
                "LOST-WORLD-GUIDE" => "LostOmensWorldGuide",
                "PATH-SOCIETY" => "PathfinderSocietyGuide",
                "SECRETS-OF-MAGIC" => "SecretsOfMagic",
                "SLITHERING" => "TheSlithering",
                "STAMINA-VARIANT" => "VariantRuleForStamina",
                "STRENGTH-THOUSANDS" => "StrengthOfThousands",
                _ => throw new NotSupportedException($"The source '{input}' is not supported.")
            };
        }
    }
}
