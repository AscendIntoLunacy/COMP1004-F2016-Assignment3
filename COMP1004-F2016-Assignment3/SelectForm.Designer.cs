namespace COMP1004_F2016_Assignment3
{
    partial class SelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectMovieLabel = new System.Windows.Forms.Label();
            this.CurrentMoviesLabel = new System.Windows.Forms.Label();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.SelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.SelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectMovieLabel
            // 
            this.SelectMovieLabel.AutoSize = true;
            this.SelectMovieLabel.Font = new System.Drawing.Font("Arimo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectMovieLabel.Location = new System.Drawing.Point(30, 31);
            this.SelectMovieLabel.Name = "SelectMovieLabel";
            this.SelectMovieLabel.Size = new System.Drawing.Size(761, 45);
            this.SelectMovieLabel.TabIndex = 0;
            this.SelectMovieLabel.Text = "Please select a movie you wish to Stream!";
            // 
            // CurrentMoviesLabel
            // 
            this.CurrentMoviesLabel.AutoSize = true;
            this.CurrentMoviesLabel.Font = new System.Drawing.Font("Arimo", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMoviesLabel.Location = new System.Drawing.Point(31, 128);
            this.CurrentMoviesLabel.Name = "CurrentMoviesLabel";
            this.CurrentMoviesLabel.Size = new System.Drawing.Size(244, 39);
            this.CurrentMoviesLabel.TabIndex = 1;
            this.CurrentMoviesLabel.Text = "Current Movies";
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.ItemHeight = 31;
            this.MovieListBox.Items.AddRange(new object[] {
            "Age of Ultron",
            "Avatar",
            "Barbie In The Nutcracker",
            "Captain America",
            "Jurassic Park",
            "Me Before You",
            "Mothers Day",
            "Saving Private Ryan",
            "Shrek",
            "Shrek 2",
            "The Avengers",
            "Titanic"});
            this.MovieListBox.Location = new System.Drawing.Point(38, 182);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(325, 500);
            this.MovieListBox.Sorted = true;
            this.MovieListBox.TabIndex = 2;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // SelectionGroupBox
            // 
            this.SelectionGroupBox.Controls.Add(this.CostTextBox);
            this.SelectionGroupBox.Controls.Add(this.CategoryTextBox);
            this.SelectionGroupBox.Controls.Add(this.TitleTextBox);
            this.SelectionGroupBox.Controls.Add(this.CostLabel);
            this.SelectionGroupBox.Controls.Add(this.CategoryLabel);
            this.SelectionGroupBox.Controls.Add(this.TitleLabel);
            this.SelectionGroupBox.Controls.Add(this.MoviePictureBox);
            this.SelectionGroupBox.Location = new System.Drawing.Point(396, 182);
            this.SelectionGroupBox.Name = "SelectionGroupBox";
            this.SelectionGroupBox.Size = new System.Drawing.Size(838, 442);
            this.SelectionGroupBox.TabIndex = 3;
            this.SelectionGroupBox.TabStop = false;
            this.SelectionGroupBox.Text = "Your Selection";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(585, 317);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(213, 38);
            this.CostTextBox.TabIndex = 6;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(303, 317);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(192, 38);
            this.CategoryTextBox.TabIndex = 5;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(303, 133);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(479, 38);
            this.TitleTextBox.TabIndex = 4;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(579, 264);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(76, 35);
            this.CostLabel.TabIndex = 3;
            this.CostLabel.Text = "Cost";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(297, 264);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(135, 35);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "Category";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Arimo", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(297, 80);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(71, 35);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title";
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(1079, 641);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(141, 55);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.Location = new System.Drawing.Point(23, 80);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(237, 348);
            this.MoviePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoviePictureBox.TabIndex = 0;
            this.MoviePictureBox.TabStop = false;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 708);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.SelectionGroupBox);
            this.Controls.Add(this.MovieListBox);
            this.Controls.Add(this.CurrentMoviesLabel);
            this.Controls.Add(this.SelectMovieLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectForm";
            this.ShowIcon = false;
            this.Text = "Movie Bonanza";
            this.SelectionGroupBox.ResumeLayout(false);
            this.SelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectMovieLabel;
        private System.Windows.Forms.Label CurrentMoviesLabel;
        private System.Windows.Forms.ListBox MovieListBox;
        private System.Windows.Forms.GroupBox SelectionGroupBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.Button NextButton;
    }
}

