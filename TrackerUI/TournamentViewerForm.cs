using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        List<int> rounds = new List<int>();
        List<MatchupModel> selectedMatchups = new List<MatchupModel>();
        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();
            tournament = tournamentModel;
            LoadFromData();
            LoadRounds();
            WireUpRounds();
        }

        private void LoadFromData()
        {
            tournamentName.Text = tournament.TournamentName;
        }
        private void WireUpRounds()
        {
            roundDropDown.DataSource = null;
            roundDropDown.DataSource = rounds;

        }
        private void WireUpMatchups()
        {
            matchuplistBox.DataSource = null;
            matchuplistBox.DataSource = selectedMatchups;
            matchuplistBox.DisplayMember = "DisplayName";
        }
        private void LoadRounds()
        {
            rounds.Add(1);
            int currRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if(matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }
        }

        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roundDropDown.SelectedItem != null)
            {
            LoadMatchups();
            }
        }
        private void LoadMatchups()
        {
            int round = (int)roundDropDown.SelectedItem;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups = matchups;
                }
            }
            WireUpMatchups();
        }
    }
}
