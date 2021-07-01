using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the place in the completion of the tournament 
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the name of the finishing place in the tournament
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the prize amount
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the prize percentage amount
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
