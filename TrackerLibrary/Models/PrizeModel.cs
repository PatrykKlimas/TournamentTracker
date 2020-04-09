using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identificator for prize
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Represents place number.
        /// </summary>
        public int PalceNumber { get; set; }
        /// <summary>
        /// Represents place name.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents price amount.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents prize percentage.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }
        public PrizeModel(string PlaceName, string PlaceNumber, string PrizeAmount, string PrizePercentage)
        {
            this.PlaceName = PlaceName;
            this.PalceNumber = int.Parse(PlaceNumber);
            this.PrizeAmount = decimal.Parse(PrizeAmount);
            this.PrizePercentage = double.Parse(PrizePercentage);
        }

    }
}
