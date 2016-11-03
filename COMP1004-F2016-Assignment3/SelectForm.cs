using COMP1004_F2016_Assignment3.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Assignment3
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (MovieListBox.SelectedIndex)
            {
                case 0:
                    ActionMovie();
                    break;
                case 1:
                    SciFiMovie();
                    break;
                case 2:
                    KidsMovie();
                    break;
                case 3:
                    ActionMovie();
                    break;
                case 4:
                    SciFiMovie();
                    break;
                case 5:
                    RomanceMovie();
                    break;
                case 6:
                    ComedyMovie();
                    break;
                case 7:
                    HistoryMovie();
                    break;
                case 8:
                    FamilyMovie();
                    break;
                case 9:
                    FamilyMovie();
                    break;
                case 10:
                    ActionMovie();
                    break;
                case 11:
                    DramaMovie();
                    break;
            }

            string imageString = Regex.Replace(TitleTextBox.Text, @"\s+", "");
            MoviePictureBox.Image = (Image)Resources.ResourceManager.GetObject(imageString);
        }

        private void DramaMovie()
        {
            TitleTextBox.Text = MovieListBox.SelectedItem.ToString();
            CategoryTextBox.Text = "Drama";
            CostTextBox.Text = "1.99";
            NextButton.Enabled = true;
        }

        private void FamilyMovie()
        {
            TitleTextBox.Text = MovieListBox.SelectedItem.ToString();
            CategoryTextBox.Text = "Family";
            CostTextBox.Text = "0.99";
            NextButton.Enabled = true;
        }

        private void HistoryMovie()
        {
            TitleTextBox.Text = MovieListBox.SelectedItem.ToString();
            CategoryTextBox.Text = "History";
            CostTextBox.Text = "2.99";
            NextButton.Enabled = true;
        }

        private void ComedyMovie()
        {
            TitleTextBox.Text = MovieListBox.SelectedItem.ToString();
            CategoryTextBox.Text = "Comedy";
            CostTextBox.Text = "1.99";
            NextButton.Enabled = true;
        }

        private void RomanceMovie()
        {
            TitleTextBox.Text = MovieListBox.SelectedItem.ToString();
            CategoryTextBox.Text = "Romance";
            CostTextBox.Text = "1.99";
            NextButton.Enabled = true;
        }

        private void KidsMovie()
        {
            TitleTextBox.Text = MovieListBox.SelectedItem.ToString();
            CategoryTextBox.Text = "Kids";
            CostTextBox.Text = "0.99";
            NextButton.Enabled = true;
        }

        private void SciFiMovie()
        {
            TitleTextBox.Text = MovieListBox.SelectedItem.ToString();
            CategoryTextBox.Text = "Sci-Fi";
            CostTextBox.Text = "2.99";
            NextButton.Enabled = true;
        }

        private void ActionMovie()
        {
            TitleTextBox.Text = MovieListBox.SelectedItem.ToString();
            CategoryTextBox.Text = "Action";
            CostTextBox.Text = "2.99";
            NextButton.Enabled = true;

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.movie.MovieTitle = TitleTextBox.Text;
            Program.movie.Category = CategoryTextBox.Text;
            Program.movie.Cost = CostTextBox.Text;
            Program.movie.MoviePoster = MoviePictureBox.Image;

            this.Hide();
            OrderForm orderForm = new OrderForm();
            orderForm.previousSelectForm = this;
            orderForm.Show();
        }
    }
}
