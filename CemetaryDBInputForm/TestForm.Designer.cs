namespace CemetaryDBInputForm
{
    partial class TestForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rulesCompliantCheckBox = new System.Windows.Forms.CheckBox();
            this.deceasedCheckBox = new System.Windows.Forms.CheckBox();
            this.markedCheckBox = new System.Windows.Forms.CheckBox();
            this.usedCheckBox = new System.Windows.Forms.CheckBox();
            this.isSoldCheckBox = new System.Windows.Forms.CheckBox();
            this.plotIdTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.plotIdLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.plotDataGridView = new System.Windows.Forms.DataGridView();
            this.loadTableButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plotDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rulesCompliantCheckBox);
            this.groupBox1.Controls.Add(this.deceasedCheckBox);
            this.groupBox1.Controls.Add(this.markedCheckBox);
            this.groupBox1.Controls.Add(this.usedCheckBox);
            this.groupBox1.Controls.Add(this.isSoldCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rulesCompliantCheckBox
            // 
            this.rulesCompliantCheckBox.AutoSize = true;
            this.rulesCompliantCheckBox.Location = new System.Drawing.Point(283, 20);
            this.rulesCompliantCheckBox.Name = "rulesCompliantCheckBox";
            this.rulesCompliantCheckBox.Size = new System.Drawing.Size(91, 17);
            this.rulesCompliantCheckBox.TabIndex = 4;
            this.rulesCompliantCheckBox.Text = "Follows Rules";
            this.rulesCompliantCheckBox.UseVisualStyleBackColor = true;
            // 
            // deceasedCheckBox
            // 
            this.deceasedCheckBox.AutoSize = true;
            this.deceasedCheckBox.Location = new System.Drawing.Point(202, 19);
            this.deceasedCheckBox.Name = "deceasedCheckBox";
            this.deceasedCheckBox.Size = new System.Drawing.Size(75, 17);
            this.deceasedCheckBox.TabIndex = 3;
            this.deceasedCheckBox.Text = "Deceased";
            this.deceasedCheckBox.UseVisualStyleBackColor = true;
            // 
            // markedCheckBox
            // 
            this.markedCheckBox.AutoSize = true;
            this.markedCheckBox.Location = new System.Drawing.Point(134, 19);
            this.markedCheckBox.Name = "markedCheckBox";
            this.markedCheckBox.Size = new System.Drawing.Size(62, 17);
            this.markedCheckBox.TabIndex = 2;
            this.markedCheckBox.Text = "Marked";
            this.markedCheckBox.UseVisualStyleBackColor = true;
            // 
            // usedCheckBox
            // 
            this.usedCheckBox.AutoSize = true;
            this.usedCheckBox.Location = new System.Drawing.Point(77, 19);
            this.usedCheckBox.Name = "usedCheckBox";
            this.usedCheckBox.Size = new System.Drawing.Size(51, 17);
            this.usedCheckBox.TabIndex = 1;
            this.usedCheckBox.Text = "Used";
            this.usedCheckBox.UseVisualStyleBackColor = true;
            // 
            // isSoldCheckBox
            // 
            this.isSoldCheckBox.AutoSize = true;
            this.isSoldCheckBox.Location = new System.Drawing.Point(24, 20);
            this.isSoldCheckBox.Name = "isSoldCheckBox";
            this.isSoldCheckBox.Size = new System.Drawing.Size(47, 17);
            this.isSoldCheckBox.TabIndex = 0;
            this.isSoldCheckBox.Text = "Sold";
            this.isSoldCheckBox.UseVisualStyleBackColor = true;
            // 
            // plotIdTextBox
            // 
            this.plotIdTextBox.Location = new System.Drawing.Point(96, 28);
            this.plotIdTextBox.Name = "plotIdTextBox";
            this.plotIdTextBox.Size = new System.Drawing.Size(344, 20);
            this.plotIdTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(96, 54);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(344, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(96, 80);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(344, 20);
            this.locationTextBox.TabIndex = 6;
            // 
            // plotIdLabel
            // 
            this.plotIdLabel.AutoSize = true;
            this.plotIdLabel.Location = new System.Drawing.Point(24, 31);
            this.plotIdLabel.Name = "plotIdLabel";
            this.plotIdLabel.Size = new System.Drawing.Size(39, 13);
            this.plotIdLabel.TabIndex = 7;
            this.plotIdLabel.Text = "Plot ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(24, 57);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(24, 83);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(48, 13);
            this.locationLabel.TabIndex = 9;
            this.locationLabel.Text = "Location";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(36, 208);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(24, 171);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(35, 13);
            this.notesLabel.TabIndex = 10;
            this.notesLabel.Text = "Notes";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(96, 168);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(344, 20);
            this.notesTextBox.TabIndex = 11;
            // 
            // plotDataGridView
            // 
            this.plotDataGridView.AllowUserToAddRows = false;
            this.plotDataGridView.AllowUserToDeleteRows = false;
            this.plotDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plotDataGridView.Location = new System.Drawing.Point(26, 249);
            this.plotDataGridView.Name = "plotDataGridView";
            this.plotDataGridView.ReadOnly = true;
            this.plotDataGridView.Size = new System.Drawing.Size(413, 203);
            this.plotDataGridView.TabIndex = 12;
            this.plotDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.plotDataGridView_CellClick);
            // 
            // loadTableButton
            // 
            this.loadTableButton.Location = new System.Drawing.Point(27, 475);
            this.loadTableButton.Name = "loadTableButton";
            this.loadTableButton.Size = new System.Drawing.Size(75, 23);
            this.loadTableButton.TabIndex = 13;
            this.loadTableButton.Text = "Load Table";
            this.loadTableButton.UseVisualStyleBackColor = true;
            this.loadTableButton.Click += new System.EventHandler(this.loadTableButton_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 513);
            this.Controls.Add(this.loadTableButton);
            this.Controls.Add(this.plotDataGridView);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.plotIdLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.plotIdTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plotDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox deceasedCheckBox;
        private System.Windows.Forms.CheckBox markedCheckBox;
        private System.Windows.Forms.CheckBox usedCheckBox;
        private System.Windows.Forms.CheckBox isSoldCheckBox;
        private System.Windows.Forms.TextBox plotIdTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label plotIdLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.CheckBox rulesCompliantCheckBox;
        private System.Windows.Forms.DataGridView plotDataGridView;
        private System.Windows.Forms.Button loadTableButton;
    }
}