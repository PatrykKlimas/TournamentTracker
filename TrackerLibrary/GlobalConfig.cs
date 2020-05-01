using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;
using System.Configuration;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public const string PrizesFile = "PrizeModels.csv";
        public const string PeopleFile = "PersonModels.csv";
        public const string TeamFile = "TeamModels.csv";
        public const string TournamentFile = "TournamentModels.csv";
        public const string MatchupFile = "MatchupModels.csv";
        public const string MatchupEntryFile = "MatchupEntryModels.csv";

        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnection(DataBaseTyoe db)
        {

            if (db == DataBaseTyoe.Sql)
            {

                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }else if (db== DataBaseTyoe.TextFile)
            {

                TextConnector text= new TextConnector();
                Connection = text;
            }
        }

        public static string ConnString(string name)
        {

            return ConfigurationManager.ConnectionStrings[name].ConnectionString; 
        }

    }
}
