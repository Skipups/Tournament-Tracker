using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of this tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the fee to enter this tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents the list of prizes for this tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents the list of matchups for each round of the tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

        /// <summary>
        /// Represents a list of teams participating in this tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();


    }
}
