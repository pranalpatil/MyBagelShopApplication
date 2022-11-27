namespace MyBagelShop
{
    partial class SearchForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.searchTrxGroupBox = new System.Windows.Forms.GroupBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.clearSearchBtn = new System.Windows.Forms.Button();
            this.searchInputTextBox = new System.Windows.Forms.TextBox();
            this.transactionNoRadioButton = new System.Windows.Forms.RadioButton();
            this.dateRadioButton = new System.Windows.Forms.RadioButton();
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.searchResultListBox = new System.Windows.Forms.ListBox();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.searchTrxGroupBox.SuspendLayout();
            this.colorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTrxGroupBox
            // 
            this.searchTrxGroupBox.Controls.Add(this.searchbutton);
            this.searchTrxGroupBox.Controls.Add(this.clearSearchBtn);
            this.searchTrxGroupBox.Controls.Add(this.searchInputTextBox);
            this.searchTrxGroupBox.Controls.Add(this.transactionNoRadioButton);
            this.searchTrxGroupBox.Controls.Add(this.dateRadioButton);
            this.searchTrxGroupBox.Controls.Add(this.searchResultLabel);
            this.searchTrxGroupBox.Controls.Add(this.searchResultListBox);
            this.searchTrxGroupBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTrxGroupBox.Location = new System.Drawing.Point(41, 203);
            this.searchTrxGroupBox.Name = "searchTrxGroupBox";
            this.searchTrxGroupBox.Size = new System.Drawing.Size(1199, 376);
            this.searchTrxGroupBox.TabIndex = 32;
            this.searchTrxGroupBox.TabStop = false;
            this.searchTrxGroupBox.Text = "Search transactions";
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(62, 238);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(143, 63);
            this.searchbutton.TabIndex = 34;
            this.searchbutton.Text = "&Search";
            this.toolTip1.SetToolTip(this.searchbutton, "Press Search Button to get Transaction details");
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // clearSearchBtn
            // 
            this.clearSearchBtn.Location = new System.Drawing.Point(62, 307);
            this.clearSearchBtn.Name = "clearSearchBtn";
            this.clearSearchBtn.Size = new System.Drawing.Size(143, 63);
            this.clearSearchBtn.TabIndex = 33;
            this.clearSearchBtn.Text = "&Clear";
            this.toolTip1.SetToolTip(this.clearSearchBtn, "Press Clear button to clear form");
            this.clearSearchBtn.UseVisualStyleBackColor = true;
            this.clearSearchBtn.Click += new System.EventHandler(this.clearSearchBtn_Click);
            // 
            // searchInputTextBox
            // 
            this.searchInputTextBox.Location = new System.Drawing.Point(31, 187);
            this.searchInputTextBox.Name = "searchInputTextBox";
            this.searchInputTextBox.Size = new System.Drawing.Size(218, 35);
            this.searchInputTextBox.TabIndex = 32;
            // 
            // transactionNoRadioButton
            // 
            this.transactionNoRadioButton.AutoSize = true;
            this.transactionNoRadioButton.Location = new System.Drawing.Point(31, 118);
            this.transactionNoRadioButton.Name = "transactionNoRadioButton";
            this.transactionNoRadioButton.Size = new System.Drawing.Size(218, 33);
            this.transactionNoRadioButton.TabIndex = 31;
            this.transactionNoRadioButton.TabStop = true;
            this.transactionNoRadioButton.Text = "Transaction No";
            this.transactionNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // dateRadioButton
            // 
            this.dateRadioButton.AutoSize = true;
            this.dateRadioButton.Location = new System.Drawing.Point(31, 65);
            this.dateRadioButton.Name = "dateRadioButton";
            this.dateRadioButton.Size = new System.Drawing.Size(268, 33);
            this.dateRadioButton.TabIndex = 30;
            this.dateRadioButton.TabStop = true;
            this.dateRadioButton.Text = "Date (MM/DD/YYYY)";
            this.dateRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchResultLabel
            // 
            this.searchResultLabel.AutoSize = true;
            this.searchResultLabel.Location = new System.Drawing.Point(775, 20);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(99, 29);
            this.searchResultLabel.TabIndex = 29;
            this.searchResultLabel.Text = "Results";
            // 
            // searchResultListBox
            // 
            this.searchResultListBox.FormattingEnabled = true;
            this.searchResultListBox.ItemHeight = 29;
            this.searchResultListBox.Location = new System.Drawing.Point(493, 52);
            this.searchResultListBox.Name = "searchResultListBox";
            this.searchResultListBox.Size = new System.Drawing.Size(665, 294);
            this.searchResultListBox.TabIndex = 28;
            // 
            // colorPanel
            // 
            this.colorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(189)))), ((int)(((byte)(207)))));
            this.colorPanel.Controls.Add(this.logoPictureBox);
            this.colorPanel.Location = new System.Drawing.Point(-3, -2);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(1377, 130);
            this.colorPanel.TabIndex = 34;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(334, 126);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(534, 651);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(230, 49);
            this.exitButton.TabIndex = 35;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(84)))), ((int)(((byte)(140)))));
            this.panel1.Location = new System.Drawing.Point(1291, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 613);
            this.panel1.TabIndex = 36;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Press Exit Button to close Search transaction ";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 769);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.searchTrxGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Transaction";
            this.searchTrxGroupBox.ResumeLayout(false);
            this.searchTrxGroupBox.PerformLayout();
            this.colorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox searchTrxGroupBox;
        private System.Windows.Forms.Button clearSearchBtn;
        private System.Windows.Forms.TextBox searchInputTextBox;
        private System.Windows.Forms.RadioButton transactionNoRadioButton;
        private System.Windows.Forms.RadioButton dateRadioButton;
        private System.Windows.Forms.Label searchResultLabel;
        private System.Windows.Forms.ListBox searchResultListBox;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}