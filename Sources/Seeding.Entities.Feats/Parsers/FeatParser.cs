using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.FileIO;
using Seeding.Feats.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seeding.Feats.Parsers
{
    public interface IFeatParser
    {
        IEnumerable<WanderersGuideFeatModel> Parse(Stream csvStream);
    }

    public class FeatParser : IFeatParser
    {
        private ILogger<FeatParser> Logger { get; }

        public FeatParser(ILogger<FeatParser> logger)
        {
            Logger = logger;
        }

        public IEnumerable<WanderersGuideFeatModel> Parse(Stream csvStream)
        {
            TextFieldParser parser = new TextFieldParser(csvStream);
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");

            while (!parser.EndOfData)
            {
                string[] row = parser.ReadFields()!;
                WanderersGuideFeatModel? feat = Deserialize(row);
                if (feat != null)
                {
                    yield return feat;
                }
            }
        }

        private WanderersGuideFeatModel? Deserialize(string[] row)
        {
            try
            {
                return new WanderersGuideFeatModel
                {
                    Id = int.Parse(row[0]),
                    Name = row[1],
                    Action = row[2],
                    Level = int.Parse(row[3]),
                    Rarity = row[4],
                    Prerequisite = row[5],
                    Cost = row[6],
                    Trigger = row[7],
                    Frequency = row[8],
                    Requirements = row[9],
                    Description = row[10],
                    Special = row[11],
                    CanSelectMultiple = bool.Parse(row[12]),
                    IsDefault = bool.Parse(row[13]),
                    SkillId = row[14],
                    MinProficiency = row[15],
                    Code = row[16],
                    IsCore = bool.Parse(row[17]),
                    GenericType = row[18],
                    GenTypeName = row[19],
                    IsArchived = bool.Parse(row[20]),
                    ContentSource = row[21],
                    Homebrew = row[22],
                    Version = int.Parse(row[23])
                };
            }
            catch (Exception exception)
            {
                Logger.LogWarning(exception, $"Could not deserialize row for feat '{row[1]}'.");
                return null;
            }
        }
    }
}
