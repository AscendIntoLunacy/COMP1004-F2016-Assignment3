﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Assignment3
{
    public partial class OrderForm : Form
    {
        public SelectForm previousSelectForm { get; set; }

        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            TitleTextBox.Text = Program.movie.MovieTitle.ToString();
            CategoryTextBox.Text = Program.movie.Category.ToString();
            SelectedMoviePictureBox.Image = Program.movie.MoviePoster;
            CostTextBox.Text = Program.movie.Cost.ToString();
            SubtotalTextBox.Text = Program.movie.Cost.ToString();

            double _subtotal;

            _subtotal = Convert.ToDouble(SubtotalTextBox.Text) * 1.13;

            GrandTotalTextBox.Text = _subtotal.ToString("#.##");

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ExitProgram();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitProgram();
        }

        private static void ExitProgram()
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

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

                double _subtotal;

                _subtotal = Convert.ToDouble(SubtotalTextBox.Text) * 1.13;

                GrandTotalTextBox.Text = _subtotal.ToString("#.##");
            }
        }


    }
}
