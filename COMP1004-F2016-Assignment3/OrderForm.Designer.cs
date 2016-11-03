namespace COMP1004_F2016_Assignment3
{
    partial class OrderForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectedGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectedMoviePictureBox = new System.Windows.Forms.PictureBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.OrderGroupBox = new System.Windows.Forms.GroupBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.DVDLabel = new System.Windows.Forms.Label();
            this.DVDCostTextBox = new System.Windows.Forms.TextBox();
            this.SubtotalLabel = new System.Windows.Forms.Label();
            this.SubtotalTextBox = new System.Windows.Forms.TextBox();
            this.LineLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.GrandTotalTextBox = new System.Windows.Forms.TextBox();
            this.DVDCheckbox = new System.Windows.Forms.CheckBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.StreamButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SelectedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedMoviePictureBox)).BeginInit();
            this.OrderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.streamToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.streamToolStripMenuItem.Text = "Stream";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SelectedGroupBox
            // 
            this.SelectedGroupBox.Controls.Add(this.SelectedMoviePictureBox);
            this.SelectedGroupBox.Controls.Add(this.CategoryTextBox);
            this.SelectedGroupBox.Controls.Add(this.CategoryLabel);
            this.SelectedGroupBox.Controls.Add(this.TitleTextBox);
            this.SelectedGroupBox.Controls.Add(this.TitleLabel);
            this.SelectedGroupBox.Location = new System.Drawing.Point(12, 27);
            this.SelectedGroupBox.Name = "SelectedGroupBox";
            this.SelectedGroupBox.Size = new System.Drawing.Size(516, 850);
            this.SelectedGroupBox.TabIndex = 1;
            this.SelectedGroupBox.TabStop = false;
            this.SelectedGroupBox.Text = "Selected Movie";
            // 
            // SelectedMoviePictureBox
            // 
            this.SelectedMoviePictureBox.Location = new System.Drawing.Point(38, 249);
            this.SelectedMoviePictureBox.Name = "SelectedMoviePictureBox";
            this.SelectedMoviePictureBox.Size = new System.Drawing.Size(431, 565);
            this.SelectedMoviePictureBox.TabIndex = 4;
            this.SelectedMoviePictureBox.TabStop = false;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(6, 176);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(498, 38);
            this.CategoryTextBox.TabIndex = 3;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(6, 142);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(125, 31);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "Category";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(6, 79);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(498, 38);
            this.TitleTextBox.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(6, 45);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(66, 31);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // OrderGroupBox
            // 
            this.OrderGroupBox.Controls.Add(this.DVDCheckbox);
            this.OrderGroupBox.Controls.Add(this.GrandTotalTextBox);
            this.OrderGroupBox.Controls.Add(this.GrandTotalLabel);
            this.OrderGroupBox.Controls.Add(this.SalesTaxTextBox);
            this.OrderGroupBox.Controls.Add(this.SalesTaxLabel);
            this.OrderGroupBox.Controls.Add(this.LineLabel);
            this.OrderGroupBox.Controls.Add(this.SubtotalTextBox);
            this.OrderGroupBox.Controls.Add(this.SubtotalLabel);
            this.OrderGroupBox.Controls.Add(this.DVDCostTextBox);
            this.OrderGroupBox.Controls.Add(this.DVDLabel);
            this.OrderGroupBox.Controls.Add(this.CostTextBox);
            this.OrderGroupBox.Controls.Add(this.CostLabel);
            this.OrderGroupBox.Location = new System.Drawing.Point(580, 27);
            this.OrderGroupBox.Name = "OrderGroupBox";
            this.OrderGroupBox.Size = new System.Drawing.Size(472, 631);
            this.OrderGroupBox.TabIndex = 5;
            this.OrderGroupBox.TabStop = false;
            this.OrderGroupBox.Text = "Your Order";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(6, 45);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(71, 31);
            this.CostLabel.TabIndex = 6;
            this.CostLabel.Text = "Cost";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(6, 79);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(460, 38);
            this.CostTextBox.TabIndex = 7;
            // 
            // DVDLabel
            // 
            this.DVDLabel.AutoSize = true;
            this.DVDLabel.Location = new System.Drawing.Point(6, 142);
            this.DVDLabel.Name = "DVDLabel";
            this.DVDLabel.Size = new System.Drawing.Size(136, 31);
            this.DVDLabel.TabIndex = 8;
            this.DVDLabel.Text = "DVD Cost";
            this.DVDLabel.Visible = false;
            // 
            // DVDCostTextBox
            // 
            this.DVDCostTextBox.Location = new System.Drawing.Point(6, 176);
            this.DVDCostTextBox.Name = "DVDCostTextBox";
            this.DVDCostTextBox.ReadOnly = true;
            this.DVDCostTextBox.Size = new System.Drawing.Size(460, 38);
            this.DVDCostTextBox.TabIndex = 9;
            this.DVDCostTextBox.Text = "10.00";
            this.DVDCostTextBox.Visible = false;
            // 
            // SubtotalLabel
            // 
            this.SubtotalLabel.AutoSize = true;
            this.SubtotalLabel.Location = new System.Drawing.Point(6, 249);
            this.SubtotalLabel.Name = "SubtotalLabel";
            this.SubtotalLabel.Size = new System.Drawing.Size(114, 31);
            this.SubtotalLabel.TabIndex = 10;
            this.SubtotalLabel.Text = "Subtotal";
            // 
            // SubtotalTextBox
            // 
            this.SubtotalTextBox.Location = new System.Drawing.Point(6, 284);
            this.SubtotalTextBox.Name = "SubtotalTextBox";
            this.SubtotalTextBox.ReadOnly = true;
            this.SubtotalTextBox.Size = new System.Drawing.Size(460, 38);
            this.SubtotalTextBox.TabIndex = 11;
            // 
            // LineLabel
            // 
            this.LineLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LineLabel.Location = new System.Drawing.Point(6, 342);
            this.LineLabel.MaximumSize = new System.Drawing.Size(0, 2);
            this.LineLabel.MinimumSize = new System.Drawing.Size(0, 2);
            this.LineLabel.Name = "LineLabel";
            this.LineLabel.Size = new System.Drawing.Size(460, 2);
            this.LineLabel.TabIndex = 12;
            this.LineLabel.Text = "label1";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(6, 370);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(213, 31);
            this.SalesTaxLabel.TabIndex = 13;
            this.SalesTaxLabel.Text = "Sales Tax (13%)";
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(6, 404);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.ReadOnly = true;
            this.SalesTaxTextBox.Size = new System.Drawing.Size(460, 38);
            this.SalesTaxTextBox.TabIndex = 14;
            this.SalesTaxTextBox.Text = "0.13";
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Location = new System.Drawing.Point(6, 459);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(150, 31);
            this.GrandTotalLabel.TabIndex = 15;
            this.GrandTotalLabel.Text = "GrandTotal";
            // 
            // GrandTotalTextBox
            // 
            this.GrandTotalTextBox.Location = new System.Drawing.Point(6, 493);
            this.GrandTotalTextBox.Name = "GrandTotalTextBox";
            this.GrandTotalTextBox.ReadOnly = true;
            this.GrandTotalTextBox.Size = new System.Drawing.Size(460, 38);
            this.GrandTotalTextBox.TabIndex = 16;
            // 
            // DVDCheckbox
            // 
            this.DVDCheckbox.AutoSize = true;
            this.DVDCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DVDCheckbox.Location = new System.Drawing.Point(6, 571);
            this.DVDCheckbox.Name = "DVDCheckbox";
            this.DVDCheckbox.Size = new System.Drawing.Size(374, 29);
            this.DVDCheckbox.TabIndex = 17;
            this.DVDCheckbox.Text = "Buy the DVD (Adds $10 to Subtotal)";
            this.DVDCheckbox.UseVisualStyleBackColor = true;
            this.DVDCheckbox.CheckedChanged += new System.EventHandler(this.DVDCheckbox_CheckedChanged);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(559, 835);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(111, 42);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(747, 835);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(111, 42);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StreamButton
            // 
            this.StreamButton.Location = new System.Drawing.Point(935, 835);
            this.StreamButton.Name = "StreamButton";
            this.StreamButton.Size = new System.Drawing.Size(111, 42);
            this.StreamButton.TabIndex = 8;
            this.StreamButton.Text = "Stream";
            this.StreamButton.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1064, 889);
            this.ControlBox = false;
            this.Controls.Add(this.StreamButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OrderGroupBox);
            this.Controls.Add(this.SelectedGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SelectedGroupBox.ResumeLayout(false);
            this.SelectedGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedMoviePictureBox)).EndInit();
            this.OrderGroupBox.ResumeLayout(false);
            this.OrderGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox SelectedGroupBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox SelectedMoviePictureBox;
        private System.Windows.Forms.GroupBox OrderGroupBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox DVDCostTextBox;
        private System.Windows.Forms.Label DVDLabel;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label LineLabel;
        private System.Windows.Forms.TextBox SubtotalTextBox;
        private System.Windows.Forms.Label SubtotalLabel;
        private System.Windows.Forms.CheckBox DVDCheckbox;
        private System.Windows.Forms.TextBox GrandTotalTextBox;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button StreamButton;
    }
}