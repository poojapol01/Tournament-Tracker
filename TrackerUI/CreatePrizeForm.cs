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

namespace TrackerUI
{
    public partial class createPrizeForm : Form
    {
        public createPrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true)
            {
                PrizeModel prizeModel = new PrizeModel(placeNumberTextBox.Text, placeNameTextBox.Text, prizeAmountTextBox.Text, prizePercentageTextBox.Text);

                foreach(IDataConnection db in GlobalConfig.connections)
                {
                    db.CreatePrize(prizeModel);
                }
                //GlobalConfig.connections.Add(prizeModel);
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidateForm() {
            bool output = true;
            //int placeNumberValidNumber = 0;
            bool placeNumberValid = int.TryParse(placeNumberTextBox.Text, out int placeNumberValue);

            if (!placeNumberValid)
            {
                return false;
            }
            if(placeNumberValue < 1 || placeNumberTextBox.Text.Length == 0)
            {
                return false;
            }


            bool prizeAmountValid = int.TryParse(prizeAmountTextBox.Text,out int prizeAmountValue);
            bool prizePercentageValid = int.TryParse(prizePercentageTextBox.Text,out int prizePercentageValue);

            if(prizeAmountValid == false || prizePercentageValid == false)
            {
                return false;
            }
            if(prizeAmountValue <= 0  && prizePercentageValue <= 0)
            {
                return false;
            }
            if (prizePercentageValue < 0 || prizePercentageValue > 100)
            {
                output = false;
            }
            return output; 
        }
    }
}
