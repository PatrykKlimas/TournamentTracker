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
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnection(DataBaseTyoe db)
        {

            if (db == DataBaseTyoe.Sql)
            {
                //TODO - Set up SQL connection properly
                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }else if (db== DataBaseTyoe.TextFile)
            {
                //TODO - Set up text connection properly
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
