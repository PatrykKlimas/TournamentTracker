using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using Dapper;

namespace TrackerLibrary.DataAccess
{
    public class SQLConnector : IDataConnection
    {

        private string connectionString = GlobalConfig.ConnString("Tournaments");
        /// <summary>
        /// Saves new prizes to database
        /// </summary>
        /// <param name="model">The prize information. </param>
        /// <returns>The prize information including the inique identificator.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.id = p.Get<int>("@id");

                return model;
            }
        }

        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmialAddress", model.EmailAddress);
                p.Add("@CellphoneNumber", model.CellphoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

                model.id = p.Get<int>("@id");

                return model;

            }
        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {

                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }

            return output;
        }

        public List<TeamModel> GetTeams_All()
        {
            List<TeamModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();

                foreach (TeamModel t in output)
                {
                    DynamicParameters p = new DynamicParameters();
                    p.Add("@TeamId", t.id);
                    t.TeamMembers = connection.Query<PersonModel>("spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }

            return output;
        }

        public TeamModel CreateTeam(TeamModel model)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                var p = new DynamicParameters();
                p.Add("@TeamName", model.TeamName);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);

                model.id = p.Get<int>("@id");

                foreach (PersonModel person in model.TeamMembers)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamId", model.id);
                    p.Add("@PersonId", person.id);

                    connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);
                }
                return model;
            }
        }

        #region CreateTournament
        public void CreateTournament(TournamentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                SaveTournament(model, connection);
                SaveTournamentPrizes(model, connection);
                SaveTournamentEntries(model, connection);
                SaveTournamentRounds(model, connection);

            }
        }

        private void SaveTournament(TournamentModel model, IDbConnection connection)
        {
            var p = new DynamicParameters();
            p.Add("@TournamentName", model.TournamentName);
            p.Add("@EntryFee", model.EntryFee);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTournaments_Insert", p, commandType: CommandType.StoredProcedure);

            model.id = p.Get<int>("@id");
        }
        private void SaveTournamentPrizes(TournamentModel model, IDbConnection connection)
        {
            DynamicParameters p;
            foreach (PrizeModel pz in model.Prizes)
            {
                p = new DynamicParameters();
                p.Add("@TournamentId", model.id);
                p.Add("@PrizeId", pz.id);

                connection.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }
        private void SaveTournamentEntries(TournamentModel model, IDbConnection connection)
        {
            DynamicParameters p;
            foreach (TeamModel teamModel in model.EnteredTeams)
            {
                p = new DynamicParameters();
                p.Add("@TournamentId", model.id);
                p.Add("@TeamId", teamModel.id);

                connection.Execute("dbo.spTournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);

            }
        }
        private void SaveTournamentRounds(TournamentModel model, IDbConnection connection)
        {
            DynamicParameters p;
            //loop throught rounds
            //loop -,- matchups
            //savematchup
            //loop rhought the entries and save
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    p = new DynamicParameters();
                    p.Add("@TournamentId", model.id);
                    p.Add("@MatchupRound", matchup.MatchupRound);
                    p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spMatchups_Insert", p, commandType: CommandType.StoredProcedure);

                    matchup.id = p.Get<int>("@id");

                    foreach (MatchupEntryModel entry in matchup.Entries)
                    {
                        p = new DynamicParameters();
                        p.Add("@MatchupId", matchup.id);

                        if (entry.ParentMatchup == null)
                        {
                            p.Add("@ParentMatchupId", null);
                        }
                        else
                        {
                            p.Add("@ParentMatchupId", entry.ParentMatchup.id);
                        }
                        if (entry.TeamCompeiting == null)
                        {
                            p.Add("@TeamCompetingId", null);
                        }
                        else
                        {
                            p.Add("@TeamCompetingId", entry.TeamCompeiting.id);
                        }
                        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                        connection.Execute("dbo.spMatchupEntries_Insert", p, commandType: CommandType.StoredProcedure);

                        entry.id = p.Get<int>("@id");

                    }
                }
            }

        }

        #endregion

        public List<TournamentModel> GetTournament_All()
        {
            List<TournamentModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {

                output = connection.Query<TournamentModel>("dbo.spTournaments_GetAll").ToList();

                DynamicParameters p;

                foreach (TournamentModel tournament in output)
                {
                    //populate prizes
                    p = new DynamicParameters();
                    p.Add("@TournamentId", tournament.id);

                    tournament.Prizes = connection.Query<PrizeModel>("dbo.spPrizes_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    tournament.EnteredTeams = connection.Query<TeamModel>("dbo.spTeam_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach (TeamModel team in tournament.EnteredTeams)
                    {
                        DynamicParameters q = new DynamicParameters();
                        q.Add("@TeamId", team.id);
                        team.TeamMembers = connection.Query<PersonModel>("spTeamMembers_GetByTeam", q, commandType: CommandType.StoredProcedure).ToList();
                    }

                    List<MatchupModel> matchups = connection.Query<MatchupModel>("dbo.spMatchups_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach (MatchupModel m in matchups)
                    {
                        DynamicParameters q = new DynamicParameters();
                        q.Add("@MatchupId", m.id);
                        m.Entries = connection.Query<MatchupEntryModel>("dbo.spMatchupEntries_GetByMatchup", q, commandType: CommandType.StoredProcedure).ToList();

                        //populate each matchup to model
                        List<TeamModel> allTeams = GetTeams_All();

                        if(m.WinnerId > 0)
                        {
                            m.Winner = allTeams.Where(x => x.id == m.WinnerId).First();
                        }

                        foreach (MatchupEntryModel me in m.Entries)
                        {
                            if (me.TeamCompetingId > 0)
                            {
                                me.TeamCompeiting = allTeams.Where(x => x.id == me.TeamCompetingId).First();
                            }

                            if (me.ParentMatchupId > 0)
                            {
                                me.ParentMatchup = matchups.Where(x => x.id == me.ParentMatchupId).First();
                            }
                        }
                    }
                    //List<List<MatchupModel>>
                    List<MatchupModel> currentRow = new List<MatchupModel>();
                    int currentRound = 1;

                    foreach (MatchupModel m in matchups)
                    {

                        //tutaj sprawdzic
                        if(m.MatchupRound > currentRound)
                        {
                            tournament.Rounds.Add(currentRow);
                            currentRow = new List<MatchupModel>();
                            currentRound += 1;
                        }

                        currentRow.Add(m);
                    }
                    tournament.Rounds.Add(currentRow);
                }


                //populate teams

                //populate rounds
            }
            return output;
        }
    }
}
