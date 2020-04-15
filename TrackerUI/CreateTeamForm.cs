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
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel(
                    firstNameValue.Text,
                    lastNameValue.Text,
                    emailValue.Text,
                    cellphoneValue.Text);

                GlobalConfig.Connection.CreatePerson(p);


                MessageBox.Show("Successuly created!");

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            }
        }
        private bool ValidateForm()
        {
            //TODO - Validate from
            if(firstNameValue.Text.Length == 0)
            {
                MessageBox.Show("Please fill first name field.");
                return false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                MessageBox.Show("Please fill last name field.");
                return false;
            }
            if(cellphoneValue.Text.Length == 0)
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
            }catch(Exception e)
            {
                return false;
            }

            return true;

        }
    }
}
