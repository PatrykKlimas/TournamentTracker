using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents all entries in the matchup model.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents the winner team in the Match.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents round number.
        /// </summary>
        public int MatchupRound { get; set; }

    }
}
