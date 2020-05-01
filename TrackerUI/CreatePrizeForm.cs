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
using TrackerLibrary;
using TrackerLibrary.DataAccess;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingForm;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNumberValue.Text,
                    placeNameValue.Text,
                    prizeAmountValue.Text,
                    pricePercentageValue.Text);


                GlobalConfig.Connection.CreatePrize(model);

                callingForm.PrizeComplete(model);

                MessageBox.Show("Successuly created!");

                this.Close();
                //placeNameValue.Text = "";
                //placeNumberValue.Text = "";
                //prizeAmountValue.Text = "0";
                //pricePercentageValue.Text = "0";
            }


        }

        private bool ValidateForm()
        {
            int placeNumber;
            //check if place number is int number
            if (!(int.TryParse(placeNumberValue.Text, out placeNumber)))
            {
                MessageBox.Show("The Place Number must be given as an integer");
                return false;
            }

            if (placeNumber < 1)
            {
                MessageBox.Show("Place number must be greater than 0.");
                return false;
            }

            if (placeNameValue.Text.Length == 0)
            {
                MessageBox.Show("Please fill Place Name");
                return false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            if (!(double.TryParse(pricePercentageValue.Text, out prizePercentage)) ||
                         !(decimal.TryParse(prizeAmountValue.Text, out prizeAmount)))
            {
                MessageBox.Show("The Prize Amount (decimal) or Prize Percentage (integer) must be filled.");
                return false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                MessageBox.Show("Either Prize amount(decimal) or Prize percentage(intager) must be filled.");
                return false;
            }

            if (prizePercentage < 0 && prizePercentage > 100)
            {
                MessageBox.Show("Prize percentage(inteager) must be given between 0 and 100.");
                return false;
            }

            if (prizeAmount < 0)
            {
                MessageBox.Show("Price amount could not be given as negative number.");
                return false;
            }

            return true;
        }
    }
}
