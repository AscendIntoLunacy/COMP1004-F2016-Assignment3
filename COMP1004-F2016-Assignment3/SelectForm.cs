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

/**
 * Application Name: Movie Bonanza
 * Author Name: Bradley Girard
 * Application Creation Date: Oct 24th, 2016
 * Application Description: An application to help customers order, and stream movies
 *                          right to their desktop.
 */

namespace COMP1004_F2016_Assignment3
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        // When respective movie is selected, will pop up the Movie Poster, its title, category and pricing
        // in the text boxes next to the list
        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Switch statement that gives the respective slots their genre and pricing.
            // EG. Movie in index 0 will be given the Action movie category and its pricing.
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

            // This gets rid of all spacing in the title text box and matches it with
            // the resource name.
            // EG. Selecting Avatar will place the Avatar movie poster in the picture box.
            string imageString = Regex.Replace(TitleTextBox.Text, @"\s+", "");
            MoviePictureBox.Image = (Image)Resources.ResourceManager.GetObject(imageString);
        }
        
        // Next several methods are for Labelling each movie to the genre that they are,
        // and also placing the price in the CostTextBox.
        // Will also enable the Next Button to be pressed to continue.
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

        // When the next button is clicked, it will store each Text Box to the resepective
        // variable in the Movie class.
        // It will also hide the Select Form, create a new Order Form, save this current form in,
        // and show the new Order Form.
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
