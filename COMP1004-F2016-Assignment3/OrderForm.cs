using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Application Name: Movie Bonanza
 * Author Name: Bradley Girard
 * Application Creation Date: Oct 24th, 2016
 * Application Description: An application to help customers order, and stream movies
 *                          right to their desktop.
 */

namespace COMP1004_F2016_Assignment3
{
    public partial class OrderForm : Form
    {
        public SelectForm previousSelectForm { get; set; }

        public OrderForm()
        {
            InitializeComponent();
        }

        // When the Order Form is loaded, it will fill in the respective text boxes
        // with information stored in the Movie class.
        // Also loads the TotalCost method that generates the total cost including taxes.
        private void OrderForm_Load(object sender, EventArgs e)
        {
            TitleTextBox.Text = Program.movie.MovieTitle.ToString();
            CategoryTextBox.Text = Program.movie.Category.ToString();
            SelectedMoviePictureBox.Image = Program.movie.MoviePoster;
            CostTextBox.Text = Program.movie.Cost.ToString();
            SubtotalTextBox.Text = Program.movie.Cost.ToString();

            TotalCost();
        }

        // When the Cancel button is clicked, will call the method to close the program.
        private void CancelButton_Click(object sender, EventArgs e)
        {
            ExitProgram();
        }

        // When the Cancel Button inthe menu strip is clicked, it will call the method to close the program.
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitProgram();
        }

        // When the About button in the menu strip is clicked, it will create a new AboutBox object
        // and show it to the user.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        // This loop will determine if the DVDCheckBox is checked and do the calculation to add the DVD 
        // cost to the grand total. Will also make the DVD Label and Text box visible.
        // If deselected, will remove the DVD cost like it was never there.
        private void DVDCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (DVDCheckbox.Checked)
            {
                double _cost, _subtotal, _grandTotal;

                DVDLabel.Visible = true;
                DVDCostTextBox.Visible = true;

                try
                {
                    _cost = Convert.ToDouble(CostTextBox.Text);
                    _subtotal = _cost + 10.00;

                    SubtotalTextBox.Text = _subtotal.ToString();

                    _grandTotal = Convert.ToDouble(SubtotalTextBox.Text) * 1.13;

                    GrandTotalTextBox.Text = _grandTotal.ToString("#.##");

                    Program.movie.TotalCost = GrandTotalTextBox.Text;
                }
                catch(Exception exception)
                {
                    MessageBox.Show("Invalid Data.", "Input Error.");
                    Debug.WriteLine(exception.Message);
                }
                
            }
            else
            {
                DVDLabel.Visible = false;
                DVDCostTextBox.Visible = false;
                SubtotalTextBox.Text = Program.movie.Cost;

                TotalCost();
            }
        }

        
        // If the Print Button in the Menu Strip is clicked, will shw message box the print preview
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here is your order!", "Print Preview", MessageBoxButtons.OKCancel);
        }

        // When the Stream button is pressed, will call the method to open the Stream Form
        private void StreamButton_Click(object sender, EventArgs e)
        {
            ShowStream();
        }


        // When the Back Button is clicked, will load the previous saved form, and close this Order Form.
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousSelectForm.Show();
            this.Close();
        }

        // When the Stream Button in the Menu Strip is clicked, will call the method to open
        // the Stream Form
        private void streamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStream();
        }

        // Method to close the program.
        private static void ExitProgram()
        {
            Application.Exit();
        }

        // Method will hide this form, create a new Stream Form object, save this current form, and 
        // show the new Stream Form
        private void ShowStream()
        {
            this.Hide();
            StreamForm streamForm = new StreamForm();
            streamForm.previousOrderForm = this;
            streamForm.Show();
        }

        // Method will calculate the total cost of the stream including taxes.
        private void TotalCost()
        {
            double _subtotal = Convert.ToDouble(SubtotalTextBox.Text) * 1.13;

            GrandTotalTextBox.Text = _subtotal.ToString("#.##");

            Program.movie.TotalCost = GrandTotalTextBox.Text;
        }
    }
}
