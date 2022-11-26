namespace MyBagelShop
{
    partial class searchTrx
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
            this.searchTrxGroupBox = new System.Windows.Forms.GroupBox();
            this.clearSearchBtn = new System.Windows.Forms.Button();
            this.searchInputTextBox = new System.Windows.Forms.TextBox();
            this.transactionNoRadioButton = new System.Windows.Forms.RadioButton();
            this.dateRadioButton = new System.Windows.Forms.RadioButton();
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.searchResultListBox = new System.Windows.Forms.ListBox();
            this.searchTrxGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTrxGroupBox
            // 
            this.searchTrxGroupBox.Controls.Add(this.clearSearchBtn);
            this.searchTrxGroupBox.Controls.Add(this.searchInputTextBox);
            this.searchTrxGroupBox.Controls.Add(this.transactionNoRadioButton);
            this.searchTrxGroupBox.Controls.Add(this.dateRadioButton);
            this.searchTrxGroupBox.Controls.Add(this.searchResultLabel);
            this.searchTrxGroupBox.Controls.Add(this.searchResultListBox);
            this.searchTrxGroupBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTrxGroupBox.Location = new System.Drawing.Point(26, 50);
            this.searchTrxGroupBox.Name = "searchTrxGroupBox";
            this.searchTrxGroupBox.Size = new System.Drawing.Size(1199, 376);
            this.searchTrxGroupBox.TabIndex = 31;
            this.searchTrxGroupBox.TabStop = false;
            this.searchTrxGroupBox.Text = "Search transactions";
            // 
            // clearSearchBtn
            // 
            this.clearSearchBtn.Location = new System.Drawing.Point(62, 283);
            this.clearSearchBtn.Name = "clearSearchBtn";
            this.clearSearchBtn.Size = new System.Drawing.Size(143, 63);
            this.clearSearchBtn.TabIndex = 33;
            this.clearSearchBtn.Text = "&Clear";
            this.clearSearchBtn.UseVisualStyleBackColor = true;
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
            this.dateRadioButton.Size = new System.Drawing.Size(270, 33);
            this.dateRadioButton.TabIndex = 30;
            this.dateRadioButton.TabStop = true;
            this.dateRadioButton.Text = "Date (MM-DD-YYYY)";
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
            // searchTrx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 653);
            this.Controls.Add(this.searchTrxGroupBox);
            this.Name = "searchTrx";
            this.Text = "Search Transaction @MyBagalShop";
            this.searchTrxGroupBox.ResumeLayout(false);
            this.searchTrxGroupBox.PerformLayout();
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
    }
}