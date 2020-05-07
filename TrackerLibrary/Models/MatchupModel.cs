using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        public int id { get; set; }
        /// <summary>
        /// Represents all entries in the matchup model.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// winner id from db to look up for the winner
        /// </summary>
        public int WinnerId { get; set; }
        /// <summary>
        /// Represents the winner team in the Match.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents round number.
        /// </summary>
        public int MatchupRound { get; set; }

        public string DisplayName
        {
            get
            {
                string output = string.Empty;
                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeiting!=null)
                    {
                        output = output == string.Empty ? me.TeamCompeiting.TeamName : output + $" vs. {me.TeamCompeiting.TeamName}";
                    }
                    else
                    {
                        output = "Matchup not yet determined";
                        break;
                    }
                }

                return output;
            }
        }
    }
}
