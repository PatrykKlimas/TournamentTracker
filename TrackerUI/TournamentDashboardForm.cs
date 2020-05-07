using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentDashboardForm : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();
        
        public TournamentDashboardForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            LoadExistingTournamentDropDown.DataSource = null;
            LoadExistingTournamentDropDown.DataSource = tournaments;
            LoadExistingTournamentDropDown.DisplayMember = "TournamentName";
        }

        private void createTournamentBotton_Click(object sender, EventArgs e)
        {
            CreateTorunamentForm frm = new CreateTorunamentForm();
            frm.Show();
        }

        private void loadTournamentButton_Click(object sender, EventArgs e)
        {
            if (LoadExistingTournamentDropDown.SelectedItem != null)
            {
                TournamentModel t = (TournamentModel)LoadExistingTournamentDropDown.SelectedItem;
                TournamentViewerForm tvForm = new TournamentViewerForm(t);
                tvForm.Show();
            }
            else
            {
                MessageBox.Show("Please seletc any tournament or create a new one.");
            }
        }
    }
}
