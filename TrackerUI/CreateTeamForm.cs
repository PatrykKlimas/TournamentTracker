using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{

    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        ITeamRequester callingForm;
        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            WireUpLists();

            callingForm = caller;
        }

        //Load members to drop down list and list box
        private void WireUpLists()
        {
            SelectTeamMemberDropDown.DataSource = null;
            SelectTeamMemberDropDown.DataSource = availableTeamMembers;
            SelectTeamMemberDropDown.DisplayMember = "FullName";

            TeamMembersListBox.DataSource = null;
            TeamMembersListBox.DataSource = selectedTeamMembers;
            TeamMembersListBox.DisplayMember = "FullName";
        }

        #region CreateMemberButton
        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel(
                    firstNameValue.Text,
                    lastNameValue.Text,
                    emailValue.Text,
                    cellphoneValue.Text);

                p = GlobalConfig.Connection.CreatePerson(p);


                MessageBox.Show("Successuly created!");

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";

                selectedTeamMembers.Add(p);
                WireUpLists();
            }
        }
        private bool ValidateForm()
        {
            //TODO - Validate from
            if (firstNameValue.Text.Length == 0)
            {
                MessageBox.Show("Please fill first name field.");
                return false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                MessageBox.Show("Please fill last name field.");
                return false;
            }
            if (cellphoneValue.Text.Length == 0)
            {
                MessageBox.Show("Please fill phonenumber field.");
                return false;
            }
            if (emailValue.Text.Length == 0)
            {
                MessageBox.Show("Please fill first email field.");
                return false;
            }
            try
            {
                MailAddress m = new MailAddress(emailValue.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Email address is not valid");
                return false;
            }

            return true;

        }
        #endregion

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            if (SelectTeamMemberDropDown.SelectedItem != null)
            {
                PersonModel p = (PersonModel)SelectTeamMemberDropDown.SelectedItem;
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
                WireUpLists();
            }
        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            if (TeamMembersListBox.SelectedItem != null)
            {
                PersonModel p = (PersonModel)TeamMembersListBox.SelectedItem;
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);
                WireUpLists();
            }
        }

        #region CreateTeamButton
        private void createTeamButton_Click(object sender, EventArgs e)
        {
            if (ValidationTeamCreate())
            {
                TeamModel t = new TeamModel();
                t.TeamMembers = selectedTeamMembers;
                t.TeamName = TeamNameValue.Text;

                GlobalConfig.Connection.CreateTeam(t);

                MessageBox.Show("Team created Successuly");

                callingForm.TeamComplete(t);
                this.Close();
            }

        }

        private bool ValidationTeamCreate()
        {
            if(TeamNameValue.Text.Length == 0)
            {
                MessageBox.Show("Please fill team name.");
                return false;
            } 

            if(selectedTeamMembers.Count == 0)
            {
                MessageBox.Show("Please add any member to the team.");
                return false;
            }

            return true;
        }

        #endregion
    }
}
