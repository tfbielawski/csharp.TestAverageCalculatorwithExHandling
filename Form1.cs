/*
/Tom Bielawski
/10-4-2020
/Starting Out With Visual C#: Tony Gaddis
/Chapter 3, Test Average Calculator
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average_Calculator_with_Ex_Handling
{
    public partial class Form1 : Form
    {
        //Initialize the form
        public Form1()
        {
            InitializeComponent();
        }

        //Clear Button Event Handler
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the three text boxes
            test1TextBox.Clear();
            test2TextBox.Clear();
            test3TextBox.Clear();

            //Clear the results label
            resultsLabel.Text = " ";

            //Change the focus back to box 1
            test1TextBox.Focus();
        }

        //Exit Button Event Handler
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Calculate Button Event Handler
        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare test and average variables
                const double QTY_TESTS = 3.0;
                double test1 = 0;
                double test2 = 0;
                double test3 = 0;
                double yourAverage = 0;


                //Convert text entries to strings
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                //Find the average
                yourAverage = (test1 + test2 + test3) / QTY_TESTS;

                //Conver the average to string for output
                //Format Number with 2 decimal places
                resultsLabel.Text = yourAverage.ToString("n2");

            }

            //Catch block to display a message to the user if any 
            //invalid data were entered.
            catch (Exception ex)
            {
                //This message displays the default exception "Input  
                //string was not in the correct format."
                MessageBox.Show(ex.Message);

                //This customized message gives the user a little more direction
                //MessageBox.Show("You entered invalid data somewhere. " +
                //    "\nPlease check your entries, press CLEAR, and try again.");
            }
        }

    }
}
