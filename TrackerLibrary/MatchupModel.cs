using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the round this matchup is a part of 
        /// </summary>
        public int MatchupRound { get; set; }

        /// <summary>
        /// Represents the set of teams that were involved in this match
        /// </summary>
        public List<MatchupEntryModel> Enteries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents the winner for this matchup
        /// </summary>
        public TeamModel Winner { get; set; }
    }
}
