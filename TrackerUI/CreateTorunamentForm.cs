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
    public partial class CreateTorunamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeams_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTorunamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            SelectTeamDropDown.DataSource = null;
            SelectTeamDropDown.DataSource = availableTeams;
            SelectTeamDropDown.DisplayMember = "TeamName";

            tournamentPlayersListBox.DataSource = null;
            tournamentPlayersListBox.DataSource = selectedTeams;
            tournamentPlayersListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
            
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            if(SelectTeamDropDown.SelectedItem !=null)
            {
                TeamModel t = (TeamModel) SelectTeamDropDown.SelectedItem;

                availableTeams.Remove(t);
                selectedTeams.Add(t);
                WireUpLists();
            }
        }

        private void deleteSelectedPlayersButton_Click(object sender, EventArgs e)
        {
            if (tournamentPlayersListBox.SelectedItem != null)
            {
                TeamModel t = new TeamModel();
                t = (TeamModel)tournamentPlayersListBox.SelectedItem;

                availableTeams.Add(t);
                selectedTeams.Remove(t);
                WireUpLists();
            }
            else {
                MessageBox.Show("Please select any player to delate");
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            //Call the create prize from

            CreatePrizeForm fPrize = new CreatePrizeForm(this);
            fPrize.Show();  
        }

        public void PrizeComplete(PrizeModel model)
        {
            //Get back from the from prize model
            selectedPrizes.Add(model);

            //Tahek prize model and put it into list of selected prizes
            WireUpLists();
        }

        private void deleteSelectPrizeButton_Click(object sender, EventArgs e)
        {
            if(prizesListBox.SelectedItem != null)
            {
                selectedPrizes.Remove((PrizeModel) prizesListBox.SelectedItem);
                WireUpLists();
            }
        }
        private void CreateNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm fTeam = new CreateTeamForm(this);
            fTeam.Show();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            //Create tournament model

            if (Validation())
            {
                TournamentModel tm = new TournamentModel();
                tm.TournamentName = TournamentNameValue.Text;
                tm.EntryFee = decimal.Parse(EntryFeeValue.Text);

                tm.Prizes = selectedPrizes;
                tm.EnteredTeams = selectedTeams;

                //Wire up our matchups

                TournamentLogic.CreateRounds(tm);

                //Create tournament entry
                //Create all prizes entries
                //Create all TournamentEntries

                GlobalConfig.Connection.CreateTournament(tm);  
            }
        }

        private bool Validation()
        {
            if(TournamentNameValue.Text == string.Empty || EntryFeeValue.Text == string.Empty)
            {
                MessageBox.Show("Please fill tournament name and entry fee");
                return false;
            }

            decimal EntryFee;
            if (!(decimal.TryParse(EntryFeeValue.Text, out EntryFee)))
            {
                MessageBox.Show("The Entry Fee must be given as an decimal");
                return false;
            }

            if(selectedPrizes.Count == 0 || selectedTeams.Count == 0)
            {
                MessageBox.Show("Please enter any prize and select any team/player");
                return false;
            }


            return true;
        }
    }
}
