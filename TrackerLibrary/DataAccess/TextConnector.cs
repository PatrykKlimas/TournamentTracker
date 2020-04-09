using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // TODO - Make the CreatePrize method saves the information to the text file
        /// <summary>
        /// Saves new prizes to text file
        /// </summary>
        /// <param name="model">The prize information. </param>
        /// <returns>The prize information including the inique identificator.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.id = 1;
            return model;
        }
    }
}
