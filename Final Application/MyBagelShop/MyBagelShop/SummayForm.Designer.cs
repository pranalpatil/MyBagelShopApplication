namespace MyBagelShop
{
    partial class SummayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummayForm));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.totalBagelLabel = new System.Windows.Forms.Label();
            this.totalSaleValueLabel = new System.Windows.Forms.Label();
            this.TotalTrxLabel = new System.Windows.Forms.Label();
            this.avgValueLabel = new System.Windows.Forms.Label();
            this.totalBagelDisplaylabel = new System.Windows.Forms.Label();
            this.TotalSaleDisplayLabel = new System.Windows.Forms.Label();
            this.totalTransactionDisplayLabel = new System.Windows.Forms.Label();
            this.AverageDisplayLabel = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.colorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(0, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(334, 126);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // colorPanel
            // 
            this.colorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(189)))), ((int)(((byte)(207)))));
            this.colorPanel.Controls.Add(this.logoPictureBox);
            this.colorPanel.Location = new System.Drawing.Point(1, -5);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(1169, 132);
            this.colorPanel.TabIndex = 35;
            // 
            // totalBagelLabel
            // 
            this.totalBagelLabel.AutoSize = true;
            this.totalBagelLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBagelLabel.Location = new System.Drawing.Point(163, 260);
            this.totalBagelLabel.Name = "totalBagelLabel";
            this.totalBagelLabel.Size = new System.Drawing.Size(221, 29);
            this.totalBagelLabel.TabIndex = 36;
            this.totalBagelLabel.Text = "Total no of Bagels";
            // 
            // totalSaleValueLabel
            // 
            this.totalSaleValueLabel.AutoSize = true;
            this.totalSaleValueLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSaleValueLabel.Location = new System.Drawing.Point(163, 333);
            this.totalSaleValueLabel.Name = "totalSaleValueLabel";
            this.totalSaleValueLabel.Size = new System.Drawing.Size(195, 29);
            this.totalSaleValueLabel.TabIndex = 37;
            this.totalSaleValueLabel.Text = "Total Sale Value";
            // 
            // TotalTrxLabel
            // 
            this.TotalTrxLabel.AutoSize = true;
            this.TotalTrxLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTrxLabel.Location = new System.Drawing.Point(163, 404);
            this.TotalTrxLabel.Name = "TotalTrxLabel";
            this.TotalTrxLabel.Size = new System.Drawing.Size(224, 29);
            this.TotalTrxLabel.TabIndex = 38;
            this.TotalTrxLabel.Text = "Total Transactions";
            // 
            // avgValueLabel
            // 
            this.avgValueLabel.AutoSize = true;
            this.avgValueLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgValueLabel.Location = new System.Drawing.Point(163, 475);
            this.avgValueLabel.Name = "avgValueLabel";
            this.avgValueLabel.Size = new System.Drawing.Size(175, 29);
            this.avgValueLabel.TabIndex = 39;
            this.avgValueLabel.Text = "Average Value";
            // 
            // totalBagelDisplaylabel
            // 
            this.totalBagelDisplaylabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalBagelDisplaylabel.Location = new System.Drawing.Point(503, 254);
            this.totalBagelDisplaylabel.Name = "totalBagelDisplaylabel";
            this.totalBagelDisplaylabel.Size = new System.Drawing.Size(314, 42);
            this.totalBagelDisplaylabel.TabIndex = 40;
            this.totalBagelDisplaylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalSaleDisplayLabel
            // 
            this.TotalSaleDisplayLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalSaleDisplayLabel.Location = new System.Drawing.Point(503, 327);
            this.TotalSaleDisplayLabel.Name = "TotalSaleDisplayLabel";
            this.TotalSaleDisplayLabel.Size = new System.Drawing.Size(314, 42);
            this.TotalSaleDisplayLabel.TabIndex = 41;
            this.TotalSaleDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalTransactionDisplayLabel
            // 
            this.totalTransactionDisplayLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalTransactionDisplayLabel.Location = new System.Drawing.Point(503, 404);
            this.totalTransactionDisplayLabel.Name = "totalTransactionDisplayLabel";
            this.totalTransactionDisplayLabel.Size = new System.Drawing.Size(314, 42);
            this.totalTransactionDisplayLabel.TabIndex = 42;
            this.totalTransactionDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AverageDisplayLabel
            // 
            this.AverageDisplayLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AverageDisplayLabel.Location = new System.Drawing.Point(503, 475);
            this.AverageDisplayLabel.Name = "AverageDisplayLabel";
            this.AverageDisplayLabel.Size = new System.Drawing.Size(314, 42);
            this.AverageDisplayLabel.TabIndex = 43;
            this.AverageDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(430, 590);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(297, 68);
            this.exitbutton.TabIndex = 44;
            this.exitbutton.Text = "E&xit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // SummayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 726);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.AverageDisplayLabel);
            this.Controls.Add(this.totalTransactionDisplayLabel);
            this.Controls.Add(this.TotalSaleDisplayLabel);
            this.Controls.Add(this.totalBagelDisplaylabel);
            this.Controls.Add(this.avgValueLabel);
            this.Controls.Add(this.TotalTrxLabel);
            this.Controls.Add(this.totalSaleValueLabel);
            this.Controls.Add(this.totalBagelLabel);
            this.Controls.Add(this.colorPanel);
            this.Name = "SummayForm";
            this.Text = "SummayForm";
            this.Load += new System.EventHandler(this.SummayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.colorPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Label totalBagelLabel;
        private System.Windows.Forms.Label totalSaleValueLabel;
        private System.Windows.Forms.Label TotalTrxLabel;
        private System.Windows.Forms.Label avgValueLabel;
        private System.Windows.Forms.Label totalBagelDisplaylabel;
        private System.Windows.Forms.Label TotalSaleDisplayLabel;
        private System.Windows.Forms.Label totalTransactionDisplayLabel;
        private System.Windows.Forms.Label AverageDisplayLabel;
        private System.Windows.Forms.Button exitbutton;
    }
}