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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBagelShopApp));
            this.topPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.wholeWheatBtn = new System.Windows.Forms.Button();
            this.selectBagelgroupBox = new System.Windows.Forms.GroupBox();
            this.saltBtn = new System.Windows.Forms.Button();
            this.cheddarBtn = new System.Windows.Forms.Button();
            this.sesameBtn = new System.Windows.Forms.Button();
            this.garlicBtn = new System.Windows.Forms.Button();
            this.eggBtn = new System.Windows.Forms.Button();
            this.frenchToastBtn = new System.Windows.Forms.Button();
            this.poppySeedBtn = new System.Windows.Forms.Button();
            this.asiagoBtn = new System.Windows.Forms.Button();
            this.onionBtn = new System.Windows.Forms.Button();
            this.chocolateChipBtn = new System.Windows.Forms.Button();
            this.blueberryBtn = new System.Windows.Forms.Button();
            this.everythingBtn = new System.Windows.Forms.Button();
            this.sizeSelectGroupBox = new System.Windows.Forms.GroupBox();
            this.extraLargeSizeBtn = new System.Windows.Forms.Button();
            this.largeSizeBtn = new System.Windows.Forms.Button();
            this.regularSizeBtn = new System.Windows.Forms.Button();
            this.mediumSizeBtn = new System.Windows.Forms.Button();
            this.smallSizeBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.ItemGroupBox = new System.Windows.Forms.ListBox();
            this.totalDisplayLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addToCartBtn = new System.Windows.Forms.Button();
            this.saleReportBtn = new System.Windows.Forms.Button();
            this.stockDataBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.extraImagePictureBox = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.btnToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.selectBagelgroupBox.SuspendLayout();
            this.sizeSelectGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extraImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(189)))), ((int)(((byte)(207)))));
            this.topPanel.Controls.Add(this.logoPictureBox);
            this.topPanel.Location = new System.Drawing.Point(0, -3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1671, 145);
            this.topPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(0, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(435, 142);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // wholeWheatBtn
            // 
            this.wholeWheatBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wholeWheatBtn.Location = new System.Drawing.Point(6, 34);
            this.wholeWheatBtn.Name = "wholeWheatBtn";
            this.wholeWheatBtn.Size = new System.Drawing.Size(148, 100);
            this.wholeWheatBtn.TabIndex = 1;
            this.wholeWheatBtn.Text = "Whole Wheat";
            this.wholeWheatBtn.UseVisualStyleBackColor = true;
            this.wholeWheatBtn.Click += new System.EventHandler(this.wholeWheatBtn_Click);
            // 
            // selectBagelgroupBox
            // 
            this.selectBagelgroupBox.Controls.Add(this.saltBtn);
            this.selectBagelgroupBox.Controls.Add(this.cheddarBtn);
            this.selectBagelgroupBox.Controls.Add(this.sesameBtn);
            this.selectBagelgroupBox.Controls.Add(this.garlicBtn);
            this.selectBagelgroupBox.Controls.Add(this.eggBtn);
            this.selectBagelgroupBox.Controls.Add(this.frenchToastBtn);
            this.selectBagelgroupBox.Controls.Add(this.poppySeedBtn);
            this.selectBagelgroupBox.Controls.Add(this.asiagoBtn);
            this.selectBagelgroupBox.Controls.Add(this.onionBtn);
            this.selectBagelgroupBox.Controls.Add(this.chocolateChipBtn);
            this.selectBagelgroupBox.Controls.Add(this.blueberryBtn);
            this.selectBagelgroupBox.Controls.Add(this.everythingBtn);
            this.selectBagelgroupBox.Controls.Add(this.wholeWheatBtn);
            this.selectBagelgroupBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBagelgroupBox.Location = new System.Drawing.Point(12, 148);
            this.selectBagelgroupBox.Name = "selectBagelgroupBox";
            this.selectBagelgroupBox.Size = new System.Drawing.Size(1024, 276);
            this.selectBagelgroupBox.TabIndex = 14;
            this.selectBagelgroupBox.TabStop = false;
            this.selectBagelgroupBox.Text = "Select Bagel";
            // 
            // saltBtn
            // 
            this.saltBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saltBtn.Location = new System.Drawing.Point(861, 90);
            this.saltBtn.Name = "saltBtn";
            this.saltBtn.Size = new System.Drawing.Size(135, 100);
            this.saltBtn.TabIndex = 13;
            this.saltBtn.Text = "Salt";
            this.saltBtn.UseVisualStyleBackColor = true;
            this.saltBtn.Click += new System.EventHandler(this.saltBtn_Click);
            // 
            // cheddarBtn
            // 
            this.cheddarBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheddarBtn.Location = new System.Drawing.Point(720, 156);
            this.cheddarBtn.Name = "cheddarBtn";
            this.cheddarBtn.Size = new System.Drawing.Size(135, 100);
            this.cheddarBtn.TabIndex = 12;
            this.cheddarBtn.Text = "Cheddar";
            this.cheddarBtn.UseVisualStyleBackColor = true;
            this.cheddarBtn.Click += new System.EventHandler(this.cheddarBtn_Click);
            // 
            // sesameBtn
            // 
            this.sesameBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sesameBtn.Location = new System.Drawing.Point(579, 156);
            this.sesameBtn.Name = "sesameBtn";
            this.sesameBtn.Size = new System.Drawing.Size(135, 100);
            this.sesameBtn.TabIndex = 11;
            this.sesameBtn.Text = "Sesame";
            this.sesameBtn.UseVisualStyleBackColor = true;
            this.sesameBtn.Click += new System.EventHandler(this.sesameBtn_Click);
            // 
            // garlicBtn
            // 
            this.garlicBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garlicBtn.Location = new System.Drawing.Point(438, 156);
            this.garlicBtn.Name = "garlicBtn";
            this.garlicBtn.Size = new System.Drawing.Size(135, 100);
            this.garlicBtn.TabIndex = 10;
            this.garlicBtn.Text = "Garlic";
            this.garlicBtn.UseVisualStyleBackColor = true;
            this.garlicBtn.Click += new System.EventHandler(this.garlicBtn_Click);
            // 
            // eggBtn
            // 
            this.eggBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eggBtn.Location = new System.Drawing.Point(297, 156);
            this.eggBtn.Name = "eggBtn";
            this.eggBtn.Size = new System.Drawing.Size(135, 100);
            this.eggBtn.TabIndex = 9;
            this.eggBtn.Text = "Egg";
            this.eggBtn.UseVisualStyleBackColor = true;
            this.eggBtn.Click += new System.EventHandler(this.eggBtn_Click);
            // 
            // frenchToastBtn
            // 
            this.frenchToastBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frenchToastBtn.Location = new System.Drawing.Point(156, 156);
            this.frenchToastBtn.Name = "frenchToastBtn";
            this.frenchToastBtn.Size = new System.Drawing.Size(135, 100);
            this.frenchToastBtn.TabIndex = 8;
            this.frenchToastBtn.Text = "French Toast";
            this.frenchToastBtn.UseVisualStyleBackColor = true;
            this.frenchToastBtn.Click += new System.EventHandler(this.frenchToastBtn_Click);
            // 
            // poppySeedBtn
            // 
            this.poppySeedBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poppySeedBtn.Location = new System.Drawing.Point(15, 156);
            this.poppySeedBtn.Name = "poppySeedBtn";
            this.poppySeedBtn.Size = new System.Drawing.Size(135, 100);
            this.poppySeedBtn.TabIndex = 7;
            this.poppySeedBtn.Text = "Poppy Seed";
            this.poppySeedBtn.UseVisualStyleBackColor = true;
            this.poppySeedBtn.Click += new System.EventHandler(this.poppySeedBtn_Click);
            // 
            // asiagoBtn
            // 
            this.asiagoBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asiagoBtn.Location = new System.Drawing.Point(720, 34);
            this.asiagoBtn.Name = "asiagoBtn";
            this.asiagoBtn.Size = new System.Drawing.Size(135, 100);
            this.asiagoBtn.TabIndex = 6;
            this.asiagoBtn.Text = "Asiago";
            this.asiagoBtn.UseVisualStyleBackColor = true;
            this.asiagoBtn.Click += new System.EventHandler(this.asiagoBtn_Click);
            // 
            // onionBtn
            // 
            this.onionBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onionBtn.Location = new System.Drawing.Point(579, 34);
            this.onionBtn.Name = "onionBtn";
            this.onionBtn.Size = new System.Drawing.Size(135, 100);
            this.onionBtn.TabIndex = 5;
            this.onionBtn.Text = "Onion";
            this.onionBtn.UseVisualStyleBackColor = true;
            this.onionBtn.Click += new System.EventHandler(this.onionBtn_Click);
            // 
            // chocolateChipBtn
            // 
            this.chocolateChipBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chocolateChipBtn.Location = new System.Drawing.Point(438, 34);
            this.chocolateChipBtn.Name = "chocolateChipBtn";
            this.chocolateChipBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chocolateChipBtn.Size = new System.Drawing.Size(144, 100);
            this.chocolateChipBtn.TabIndex = 4;
            this.chocolateChipBtn.Text = "Chocolate Chip";
            this.chocolateChipBtn.UseVisualStyleBackColor = true;
            this.chocolateChipBtn.Click += new System.EventHandler(this.chocolateChipBtn_Click);
            // 
            // blueberryBtn
            // 
            this.blueberryBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueberryBtn.Location = new System.Drawing.Point(297, 34);
            this.blueberryBtn.Name = "blueberryBtn";
            this.blueberryBtn.Size = new System.Drawing.Size(146, 100);
            this.blueberryBtn.TabIndex = 3;
            this.blueberryBtn.Text = "Blueberry";
            this.blueberryBtn.UseVisualStyleBackColor = true;
            this.blueberryBtn.Click += new System.EventHandler(this.blueberryBtn_Click);
            // 
            // everythingBtn
            // 
            this.everythingBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.everythingBtn.Location = new System.Drawing.Point(156, 34);
            this.everythingBtn.Name = "everythingBtn";
            this.everythingBtn.Size = new System.Drawing.Size(148, 100);
            this.everythingBtn.TabIndex = 2;
            this.everythingBtn.Text = "Everything";
            this.everythingBtn.UseVisualStyleBackColor = true;
            this.everythingBtn.Click += new System.EventHandler(this.everythingBtn_Click);
            // 
            // sizeSelectGroupBox
            // 
            this.sizeSelectGroupBox.Controls.Add(this.extraLargeSizeBtn);
            this.sizeSelectGroupBox.Controls.Add(this.largeSizeBtn);
            this.sizeSelectGroupBox.Controls.Add(this.regularSizeBtn);
            this.sizeSelectGroupBox.Controls.Add(this.mediumSizeBtn);
            this.sizeSelectGroupBox.Controls.Add(this.smallSizeBtn);
            this.sizeSelectGroupBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeSelectGroupBox.Location = new System.Drawing.Point(1042, 160);
            this.sizeSelectGroupBox.Name = "sizeSelectGroupBox";
            this.sizeSelectGroupBox.Size = new System.Drawing.Size(487, 264);
            this.sizeSelectGroupBox.TabIndex = 15;
            this.sizeSelectGroupBox.TabStop = false;
            this.sizeSelectGroupBox.Text = "Select Size";
            // 
            // extraLargeSizeBtn
            // 
            this.extraLargeSizeBtn.Location = new System.Drawing.Point(142, 190);
            this.extraLargeSizeBtn.Name = "extraLargeSizeBtn";
            this.extraLargeSizeBtn.Size = new System.Drawing.Size(182, 68);
            this.extraLargeSizeBtn.TabIndex = 4;
            this.extraLargeSizeBtn.Text = "Extra-Large";
            this.extraLargeSizeBtn.UseVisualStyleBackColor = true;
            this.extraLargeSizeBtn.Click += new System.EventHandler(this.extraLargeSizeBtn_Click);
            // 
            // largeSizeBtn
            // 
            this.largeSizeBtn.Location = new System.Drawing.Point(252, 110);
            this.largeSizeBtn.Name = "largeSizeBtn";
            this.largeSizeBtn.Size = new System.Drawing.Size(182, 68);
            this.largeSizeBtn.TabIndex = 3;
            this.largeSizeBtn.Text = "Large";
            this.largeSizeBtn.UseVisualStyleBackColor = true;
            this.largeSizeBtn.Click += new System.EventHandler(this.largeSizeBtn_Click);
            // 
            // regularSizeBtn
            // 
            this.regularSizeBtn.Location = new System.Drawing.Point(26, 110);
            this.regularSizeBtn.Name = "regularSizeBtn";
            this.regularSizeBtn.Size = new System.Drawing.Size(182, 68);
            this.regularSizeBtn.TabIndex = 2;
            this.regularSizeBtn.Text = "Regular";
            this.regularSizeBtn.UseVisualStyleBackColor = true;
            this.regularSizeBtn.Click += new System.EventHandler(this.regularSizeBtn_Click);
            // 
            // mediumSizeBtn
            // 
            this.mediumSizeBtn.Location = new System.Drawing.Point(252, 34);
            this.mediumSizeBtn.Name = "mediumSizeBtn";
            this.mediumSizeBtn.Size = new System.Drawing.Size(182, 68);
            this.mediumSizeBtn.TabIndex = 1;
            this.mediumSizeBtn.Text = "Medium";
            this.mediumSizeBtn.UseVisualStyleBackColor = true;
            this.mediumSizeBtn.Click += new System.EventHandler(this.mediumSizeBtn_Click);
            // 
            // smallSizeBtn
            // 
            this.smallSizeBtn.Location = new System.Drawing.Point(26, 34);
            this.smallSizeBtn.Name = "smallSizeBtn";
            this.smallSizeBtn.Size = new System.Drawing.Size(182, 68);
            this.smallSizeBtn.TabIndex = 0;
            this.smallSizeBtn.Text = "Small";
            this.smallSizeBtn.UseVisualStyleBackColor = true;
            this.smallSizeBtn.Click += new System.EventHandler(this.smallSizeBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(84)))), ((int)(((byte)(140)))));
            this.orderBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orderBtn.Location = new System.Drawing.Point(780, 703);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(216, 65);
            this.orderBtn.TabIndex = 26;
            this.orderBtn.Text = "&Order";
            this.btnToolTip.SetToolTip(this.orderBtn, "Press the order button To place an order & checkout");
            this.orderBtn.UseVisualStyleBackColor = false;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // ItemGroupBox
            // 
            this.ItemGroupBox.FormattingEnabled = true;
            this.ItemGroupBox.ItemHeight = 25;
            this.ItemGroupBox.Location = new System.Drawing.Point(12, 507);
            this.ItemGroupBox.Name = "ItemGroupBox";
            this.ItemGroupBox.Size = new System.Drawing.Size(523, 329);
            this.ItemGroupBox.TabIndex = 17;
            // 
            // totalDisplayLabel
            // 
            this.totalDisplayLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalDisplayLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDisplayLabel.Location = new System.Drawing.Point(573, 520);
            this.totalDisplayLabel.Name = "totalDisplayLabel";
            this.totalDisplayLabel.Size = new System.Drawing.Size(139, 123);
            this.totalDisplayLabel.TabIndex = 22;
            this.totalDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(594, 476);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(93, 37);
            this.totalLabel.TabIndex = 20;
            this.totalLabel.Text = "Total";
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(780, 600);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(216, 65);
            this.clearBtn.TabIndex = 25;
            this.clearBtn.Text = "&Clear";
            this.btnToolTip.SetToolTip(this.clearBtn, "Press Clear button to take new order");
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartBtn.Location = new System.Drawing.Point(780, 487);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Size = new System.Drawing.Size(216, 65);
            this.addToCartBtn.TabIndex = 24;
            this.addToCartBtn.Text = "&Add to Cart";
            this.btnToolTip.SetToolTip(this.addToCartBtn, "Press the Add to Cart button, To add the chosen bagel to your cart");
            this.addToCartBtn.UseVisualStyleBackColor = true;
            this.addToCartBtn.Click += new System.EventHandler(this.addToCartBtn_Click);
            // 
            // saleReportBtn
            // 
            this.saleReportBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleReportBtn.Location = new System.Drawing.Point(1106, 600);
            this.saleReportBtn.Name = "saleReportBtn";
            this.saleReportBtn.Size = new System.Drawing.Size(216, 65);
            this.saleReportBtn.TabIndex = 28;
            this.saleReportBtn.Text = "&Sale Report";
            this.btnToolTip.SetToolTip(this.saleReportBtn, "Press the sale report button to show compnay sale report ");
            this.saleReportBtn.UseVisualStyleBackColor = true;
            // 
            // stockDataBtn
            // 
            this.stockDataBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDataBtn.Location = new System.Drawing.Point(1106, 703);
            this.stockDataBtn.Name = "stockDataBtn";
            this.stockDataBtn.Size = new System.Drawing.Size(216, 65);
            this.stockDataBtn.TabIndex = 29;
            this.stockDataBtn.Text = "Stock &Data";
            this.btnToolTip.SetToolTip(this.stockDataBtn, "Press the Stock Data button to check pending stock. ");
            this.stockDataBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(1106, 487);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(216, 65);
            this.searchBtn.TabIndex = 28;
            this.searchBtn.Text = "S&earch";
            this.btnToolTip.SetToolTip(this.searchBtn, "Press the Search Button to find Transactions.");
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(31)))), ((int)(((byte)(101)))));
            this.panel1.Location = new System.Drawing.Point(1049, 485);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 283);
            this.panel1.TabIndex = 31;
            // 
            // extraImagePictureBox
            // 
            this.extraImagePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("extraImagePictureBox.Image")));
            this.extraImagePictureBox.Location = new System.Drawing.Point(1393, 525);
            this.extraImagePictureBox.Name = "extraImagePictureBox";
            this.extraImagePictureBox.Size = new System.Drawing.Size(235, 243);
            this.extraImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.extraImagePictureBox.TabIndex = 32;
            this.extraImagePictureBox.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(1403, 797);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(216, 65);
            this.exitBtn.TabIndex = 33;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // btnToolTip
            // 
            this.btnToolTip.IsBalloon = true;
            this.btnToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.btnToolTip.ToolTipTitle = "Info";
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new System.Drawing.Point(189, 448);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(100, 31);
            this.qtyTextBox.TabIndex = 34;
            // 
            // MyBagelShopApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1668, 892);
            this.Controls.Add(this.qtyTextBox);
            this.Controls.Add(this.ItemGroupBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.totalDisplayLabel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.extraImagePictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addToCartBtn);
            this.Controls.Add(this.stockDataBtn);
            this.Controls.Add(this.saleReportBtn);
            this.Controls.Add(this.sizeSelectGroupBox);
            this.Controls.Add(this.selectBagelgroupBox);
            this.Controls.Add(this.topPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyBagelShopApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to MyBagelShop";
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.selectBagelgroupBox.ResumeLayout(false);
            this.sizeSelectGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.extraImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button wholeWheatBtn;
        private System.Windows.Forms.GroupBox selectBagelgroupBox;
        private System.Windows.Forms.Button saltBtn;
        private System.Windows.Forms.Button cheddarBtn;
        private System.Windows.Forms.Button sesameBtn;
        private System.Windows.Forms.Button garlicBtn;
        private System.Windows.Forms.Button eggBtn;
        private System.Windows.Forms.Button frenchToastBtn;
        private System.Windows.Forms.Button poppySeedBtn;
        private System.Windows.Forms.Button asiagoBtn;
        private System.Windows.Forms.Button onionBtn;
        private System.Windows.Forms.Button chocolateChipBtn;
        private System.Windows.Forms.Button blueberryBtn;
        private System.Windows.Forms.Button everythingBtn;
        private System.Windows.Forms.GroupBox sizeSelectGroupBox;
        private System.Windows.Forms.Button extraLargeSizeBtn;
        private System.Windows.Forms.Button largeSizeBtn;
        private System.Windows.Forms.Button regularSizeBtn;
        private System.Windows.Forms.Button mediumSizeBtn;
        private System.Windows.Forms.Button smallSizeBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addToCartBtn;
        private System.Windows.Forms.Label totalDisplayLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button saleReportBtn;
        private System.Windows.Forms.Button stockDataBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox extraImagePictureBox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ToolTip btnToolTip;
        private System.Windows.Forms.ListBox ItemGroupBox;
        private System.Windows.Forms.TextBox qtyTextBox;
    }
}

