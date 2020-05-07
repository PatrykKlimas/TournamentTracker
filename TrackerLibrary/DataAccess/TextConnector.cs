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
        private const string PeopleFile = "PersonModels.csv";
        private const string TeamFile = "TeamModels.csv";
        private const string TournamentFile = "TournamentModels.csv";
        private const string MatchupFile = "MatchupModels.csv";
        private const string MatchupEntryFile = "MatchupEntryModels.csv";

        /// <summary>
        /// Saves new prizes to text file
        /// </summary>
        /// <param name="model">The prize information. </param>
        /// <returns>The prize information including the inique identificator.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //Load the text file and convert text to list of price model
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

            //Load the text file and convert text to list of peron model
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertPersonModels();
            // Find last id

            int currentID = 1;

            if (people.Count() > 0)
            {
                currentID = people.OrderByDescending(x => x.id).First().id + 1;
            }

            model.id = currentID;

            //Add new record with id (last + 1)
            people.Add(model);

            //Convert the people to a list<string>
            //Save the list of string to the text file
            people.SaveToPeopleFile(PeopleFile);

            return model;
        }

        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertPersonModels();
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertTeamModels(PeopleFile);

            int currentID = 1;

            if (teams.Count() > 0)
            {
                currentID = teams.OrderByDescending(x => x.id).First().id + 1;
            }

            model.id = currentID;
            teams.Add(model);
            teams.SaveToTeamsFile(TeamFile);

            return model;

        }

        public List<TeamModel> GetTeams_All()
        {
            return TeamFile.FullFilePath().LoadFile().ConvertTeamModels(PeopleFile);
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamentFile.FullFilePath().LoadFile().ConvertTournamentModels( PrizesFile , TeamFile, PeopleFile);
            int currentID = 1;

            if (tournaments.Count() > 0)
            {
                currentID = tournaments.OrderByDescending(x => x.id).First().id + 1;
            }

            model.id = currentID;
            model.SaveRoundsToFile();
            tournaments.Add(model);
            tournaments.SaveToTournamentsFile(TournamentFile);

        }

        public List<TournamentModel> GetTournament_All()
        {
            return TournamentFile.FullFilePath().LoadFile().ConvertTournamentModels(PrizesFile, TeamFile, PeopleFile);
        }
    }
}
