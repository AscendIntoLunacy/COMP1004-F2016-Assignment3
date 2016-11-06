using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class StreamForm : Form
    {
        public OrderForm previousOrderForm { get; set; }
        public StreamForm()
        {
            InitializeComponent();
        }

        // When the OK Button is clicked, will close the program.
        private void OkButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // When the Stream Form loads, will input the Total Cost and Movie title to the stream form.
        private void StreamForm_Load(object sender, EventArgs e)
        {
            CreditCardLabel.Text = "Your credit card will be charged " + Program.movie.TotalCost.ToString();
            MovieLabel.Text = Program.movie.MovieTitle.ToString() +  " will begin momentarily";
        }
    }
}
