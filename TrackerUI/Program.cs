using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Initialize the database connections
            TrackerLibrary.GlobalConfig.InitializeConnection(TrackerLibrary.DataBaseTyoe.Sql);

            // Application.Run(new TournamentDashboardForm());
            Application.Run(new TournamentDashboardForm());
        }
    }
}
