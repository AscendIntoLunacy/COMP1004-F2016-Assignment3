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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        // Turns the Timer off after 3 seconds, starts a new Select Form then hides the splash screen
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            SplashFormTimer.Enabled = false;
            SelectForm selectForm = new SelectForm();
            selectForm.Show();
            this.Hide();
        }
    }
}
