using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    //I would like to store each table in separate text file (file = table in db)
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        // TODO - Make the CreatePrize method saves the information to the text file
        /// <summary>
        /// Saves new prizes to text file
        /// </summary>
        /// <param name="model">The prize information. </param>
        /// <returns>The prize information including the inique identificator.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //Load the text file and convert text to list of price podel
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertPrizeModels();
            // Find last id

            int currentID = 1;
            
            if (prizes.Count() > 0)
            {
                currentID = prizes.OrderByDescending(x => x.id).First().id + 1; 
            }

            model.id = currentID;

            //Add new record with id (last + 1)
            prizes.Add(model);

            //Convert the prizes to a list<string>
            //Save the list of string to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }


        public PersonModel CreatePerson(PersonModel model)
        {

            //TODO - mplement this method
            throw new NotImplementedException();
        }
    }
}
