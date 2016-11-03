using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Assignment3
{
    public partial class StreamForm : Form
    {
        public OrderForm previousOrderForm { get; set; }
        public StreamForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StreamForm_Load(object sender, EventArgs e)
        {
            CreditCardLabel.Text = "Your credit card will be charged " + Program.movie.TotalCost.ToString();
            MovieLabel.Text = Program.movie.MovieTitle.ToString() +  " will begin momentarily";
        }
    }
}
