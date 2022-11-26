namespace MyBagelShop
{
    partial class MyBagelShopApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBagelShopApp));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.bagelTypeListBox = new System.Windows.Forms.ListBox();
            this.bagelTypeLabel = new System.Windows.Forms.Label();
            this.bagelSizeLabel = new System.Windows.Forms.Label();
            this.addToCartBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.bagelSizeListBox = new System.Windows.Forms.ListBox();
            this.qytNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.displayListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.saleReportBtn = new System.Windows.Forms.Button();
            this.stockDataBtn = new System.Windows.Forms.Button();
            this.summaryBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.colorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qytNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(3, 18);
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
            this.colorPanel.Location = new System.Drawing.Point(-8, -16);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(1417, 144);
            this.colorPanel.TabIndex = 1;
            // 
            // bagelTypeListBox
            // 
            this.bagelTypeListBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagelTypeListBox.FormattingEnabled = true;
            this.bagelTypeListBox.ItemHeight = 29;
            this.bagelTypeListBox.Items.AddRange(new object[] {
            "Whole Wheat",
            "Everything",
            "Blueberry",
            "Chocolate Chip",
            "Onion",
            "Asiago",
            "Salt",
            "Poppy Seed",
            "French Toast",
            "Egg",
            "Garlic",
            "Sesame",
            "Cheddar"});
            this.bagelTypeListBox.Location = new System.Drawing.Point(12, 189);
            this.bagelTypeListBox.Name = "bagelTypeListBox";
            this.bagelTypeListBox.Size = new System.Drawing.Size(277, 410);
            this.bagelTypeListBox.TabIndex = 2;
            // 
            // bagelTypeLabel
            // 
            this.bagelTypeLabel.AutoSize = true;
            this.bagelTypeLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagelTypeLabel.Location = new System.Drawing.Point(71, 157);
            this.bagelTypeLabel.Name = "bagelTypeLabel";
            this.bagelTypeLabel.Size = new System.Drawing.Size(67, 29);
            this.bagelTypeLabel.TabIndex = 4;
            this.bagelTypeLabel.Text = "Type";
            // 
            // bagelSizeLabel
            // 
            this.bagelSizeLabel.AutoSize = true;
            this.bagelSizeLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagelSizeLabel.Location = new System.Drawing.Point(304, 157);
            this.bagelSizeLabel.Name = "bagelSizeLabel";
            this.bagelSizeLabel.Size = new System.Drawing.Size(61, 29);
            this.bagelSizeLabel.TabIndex = 5;
            this.bagelSizeLabel.Text = "Size";
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(189)))), ((int)(((byte)(207)))));
            this.addToCartBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartBtn.Location = new System.Drawing.Point(553, 269);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Size = new System.Drawing.Size(147, 75);
            this.addToCartBtn.TabIndex = 6;
            this.addToCartBtn.Text = "&Add to Cart";
            this.addToCartBtn.UseVisualStyleBackColor = false;
            this.addToCartBtn.Click += new System.EventHandler(this.addToCartBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(393, 691);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(147, 51);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "&Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(84)))), ((int)(((byte)(140)))));
            this.orderBtn.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orderBtn.Location = new System.Drawing.Point(739, 691);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(147, 51);
            this.orderBtn.TabIndex = 9;
            this.orderBtn.Text = "&Order";
            this.orderBtn.UseVisualStyleBackColor = false;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // bagelSizeListBox
            // 
            this.bagelSizeListBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagelSizeListBox.FormattingEnabled = true;
            this.bagelSizeListBox.ItemHeight = 29;
            this.bagelSizeListBox.Location = new System.Drawing.Point(315, 189);
            this.bagelSizeListBox.Name = "bagelSizeListBox";
            this.bagelSizeListBox.Size = new System.Drawing.Size(193, 149);
            this.bagelSizeListBox.TabIndex = 3;
            // 
            // qytNumericUpDown
            // 
            this.qytNumericUpDown.Location = new System.Drawing.Point(553, 189);
            this.qytNumericUpDown.Name = "qytNumericUpDown";
            this.qytNumericUpDown.Size = new System.Drawing.Size(147, 31);
            this.qytNumericUpDown.TabIndex = 11;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalPriceLabel.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(782, 278);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(193, 66);
            this.totalPriceLabel.TabIndex = 12;
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayListView
            // 
            this.displayListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.displayListView.HideSelection = false;
            this.displayListView.Location = new System.Drawing.Point(309, 385);
            this.displayListView.Name = "displayListView";
            this.displayListView.Size = new System.Drawing.Size(738, 287);
            this.displayListView.TabIndex = 13;
            this.displayListView.UseCompatibleStateImageBehavior = false;
            this.displayListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.Width = 90;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(84)))), ((int)(((byte)(140)))));
            this.panel1.Location = new System.Drawing.Point(1103, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 510);
            this.panel1.TabIndex = 14;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(1155, 293);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(147, 51);
            this.SearchButton.TabIndex = 15;
            this.SearchButton.Text = "&Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // saleReportBtn
            // 
            this.saleReportBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleReportBtn.Location = new System.Drawing.Point(1155, 445);
            this.saleReportBtn.Name = "saleReportBtn";
            this.saleReportBtn.Size = new System.Drawing.Size(147, 51);
            this.saleReportBtn.TabIndex = 16;
            this.saleReportBtn.Text = "Sale &Report";
            this.saleReportBtn.UseVisualStyleBackColor = true;
            // 
            // stockDataBtn
            // 
            this.stockDataBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDataBtn.Location = new System.Drawing.Point(1155, 369);
            this.stockDataBtn.Name = "stockDataBtn";
            this.stockDataBtn.Size = new System.Drawing.Size(147, 51);
            this.stockDataBtn.TabIndex = 17;
            this.stockDataBtn.Text = "Stock &Data";
            this.stockDataBtn.UseVisualStyleBackColor = true;
            // 
            // summaryBtn
            // 
            this.summaryBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryBtn.Location = new System.Drawing.Point(1155, 520);
            this.summaryBtn.Name = "summaryBtn";
            this.summaryBtn.Size = new System.Drawing.Size(147, 51);
            this.summaryBtn.TabIndex = 18;
            this.summaryBtn.Text = "Su&mmary";
            this.summaryBtn.UseVisualStyleBackColor = true;
            // 
            // MyBagelShopApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 797);
            this.Controls.Add(this.summaryBtn);
            this.Controls.Add(this.stockDataBtn);
            this.Controls.Add(this.saleReportBtn);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.displayListView);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.qytNumericUpDown);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addToCartBtn);
            this.Controls.Add(this.bagelSizeLabel);
            this.Controls.Add(this.bagelTypeLabel);
            this.Controls.Add(this.bagelTypeListBox);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.bagelSizeListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyBagelShopApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Welcome to MyBagelShop";
            this.Load += new System.EventHandler(this.MyBagelShopApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.colorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qytNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.ListBox bagelTypeListBox;
        private System.Windows.Forms.Label bagelTypeLabel;
        private System.Windows.Forms.Label bagelSizeLabel;
        private System.Windows.Forms.Button addToCartBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.ListBox bagelSizeListBox;
        private System.Windows.Forms.NumericUpDown qytNumericUpDown;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.ListView displayListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button saleReportBtn;
        private System.Windows.Forms.Button stockDataBtn;
        private System.Windows.Forms.Button summaryBtn;
    }
}

