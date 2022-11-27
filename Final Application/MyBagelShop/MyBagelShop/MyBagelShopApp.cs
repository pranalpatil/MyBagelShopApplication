/* Student Name: Pranal Patil
 * Student ID: 22222293
 * Date:28/11/2022
 * Assignment: 4
 * Assignment: The management team at your client MyBagelShop Inc. (MBSI), a regional chain of 
 * gourmet bagel bars, wants to become more methodical and systems-oriented in their business 
 * strategy as a result of the company's rapid rate of development. A well-designed electronic 
 * point of sale (EPOS) application will be developed by your organization and used by the counter 
 * \employees to process client orders. The EPOS will be used by MBSI to process and record sales of 
 * their gourmet bagels to customers, offer inventory management so they can keep an eye on supply levels, 
 * and give real-time and detailed information so they can make smarter business choices.
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBagelShop
{
    public partial class MyBagelShopApp : Form
    {
        public MyBagelShopApp()
        {
            InitializeComponent();
        }
        // Created below variables so we can pass to another form. 
        public static decimal BagelOverall { get; private set; } = 0;
        public static decimal tempTotalPrice { get; private set; } = 0;
        public static decimal avgOverall { get; private set; } = 0;
        public static decimal Count { get; private set; } = 0;
        // Declearing the Variables and storing the Names & Size in arrays
        decimal[,] FinalBagelprice = new decimal[13, 5];
        const string PriceFilePath = "PriceListBagel.txt";
        const string StockFilePath = "StockData.txt";
        const string TransactionFilePath = "TransactionData.txt";
        const string SalereportFilePath = "SalesReport.txt";
        private static String[] BeagelNames = { "Whole Wheat", "Everything", "Blueberry", "Chocolate Chip", "Onion", "Asiago", "Salt", "Poppy Seed", "French Toast", "Egg", "Garlic", "Sesame", "Cheddar" };
        private static String[] Bagelsizes = { "Small", "Medium", "Regular", "Large", "Extra-Large " };
        int bagelTypeIndex = 0, bagelSizeIndex = 0, qytOrder=0;
        decimal finalCost = 0;
        decimal totalStoreCost;
        List<string> BagelQty = new List<string>();
        int[,] ArrayStock = new int[13, 5];
        int[,] ArraySales = new int[13, 5];
        Boolean DotFlag;
        string TrxID = "", QtyTotal="";
        int StockItemIndex, StockIndexSize;
        


        // Reading the prices of Bagel from Text File.
        public Boolean BagelPrices()
        {
            int Row = 0;
            string priceBagel = File.ReadAllText(PriceFilePath);
            string[] RowData, AllRowData;
            AllRowData=File.ReadAllLines(PriceFilePath);

            for (Row=0; Row<AllRowData.Length; Row++)
            {
                RowData=AllRowData[Row].Split(',');

                for (int Column = 0; Column<RowData.Length; Column++)
                {
                    FinalBagelprice[Row, Column]=decimal.Parse(RowData[Column]);

                }
            }
            Console.WriteLine(FinalBagelprice[1, 2]);
            return true;

        }
        
        
        // Created an method to genrate traansaction no for 5 digit.
        private string getRandomTransactionNo()
        {
            string transactionNo;
            Random random = new Random();
            do
            {
                return random.Next(10000, 100000).ToString();
            }
            while (!alreadyrecord(transactionNo));

        }
        private bool alreadyrecord(string NUM)
        {
            bool found = false;
            return found;
        }
        // Calling the File price file on Form load. 
        private void MyBagelShopApp_Load(object sender, EventArgs e)
        {
            orderBtn.Enabled = false;
            if (BagelPrices())
            {
                for (int i = 0; i< Bagelsizes.Length; i++)
                {
                    bagelSizeListBox.Items.Add(Bagelsizes[i].ToString());
                }
            }
            BagelPrices();

            File.WriteAllText(StockFilePath, string.Empty);
            StreamWriter streamWriter = File.AppendText(StockFilePath);

            // Prinitng the column headings in text File
            for (int p = 0; p < Bagelsizes.Length; p++)
            {
                streamWriter.Write("\t" + Bagelsizes[p]);
                if (p == (Bagelsizes.Length - 1))
                {
                    streamWriter.WriteLine("\n");
                }
            }

            // Printing stock data & row headers in text file.
            for (int r = 0; r < BeagelNames.Length; r++)
            {
                streamWriter.Write(BeagelNames[r] + "\t");

                for (int a = 0; a < Bagelsizes.Length; a++)
                {
                    ArrayStock[r, a] = 50;
                    ArraySales[r, a] = 0;
                    streamWriter.Write(ArrayStock[r, a] + "\t");
                }
                streamWriter.Write("\n");
            }
            streamWriter.Close();
        }
        // Add to cart button used to add selected bagel and size into data list view. 
        private void addToCartBtn_Click(object sender, EventArgs e)

        {
            // checking validation if bagel type is selected or not.
            if (bagelTypeListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select at least one Bagel Type","Warning",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            // checking validation if bagel Size is selected or not.

            else if (bagelSizeListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select at least one Bagel Size", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // checking validation if Qyt is entered .

            else if (qytNumericUpDown.Value <=0)
            {
                MessageBox.Show("Please enter the Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (bagelTypeListBox.SelectedIndex != -1)
                {
                    if (bagelSizeListBox.SelectedIndex !=-1)
                    {
                        bagelTypeIndex=bagelTypeListBox.SelectedIndex;
                        bagelSizeIndex=bagelSizeListBox.SelectedIndex;

                        qytOrder=Convert.ToInt32(qytNumericUpDown.Value);

                        finalCost=qytOrder*FinalBagelprice[bagelTypeIndex, bagelSizeIndex];
                        // storing the seleted data from list view.
                        ListViewItem Items =new ListViewItem(BeagelNames[bagelTypeIndex]);
                        Items.SubItems.Add(Bagelsizes[bagelSizeIndex]);
                        Items.SubItems.Add(qytOrder.ToString());
                        Items.SubItems.Add(finalCost.ToString("C2"));
                        displayListView.Items.Add(Items);
                        BagelQty.Add(BeagelNames[bagelTypeIndex]+","+Bagelsizes[bagelSizeIndex] + "," +qytOrder);
                        totalStoreCost +=finalCost;
                        totalPriceLabel.Text= totalStoreCost.ToString("C2");
                        QtyTotal += qytOrder;
                        BagelOverall+=qytOrder;

                    }
                }

                orderBtn.Enabled = true;
                qytNumericUpDown.Value=0;
                bagelTypeListBox.ClearSelected();
                bagelSizeListBox.ClearSelected();

            }

        }
        public void orderData()
        {
            string writeData = string.Join(",", BagelQty);
            if (!File.Exists(TransactionFilePath))
            {
                using (StreamWriter writefile = File.AppendText(TransactionFilePath))
                {
                    writefile.WriteLine(writeData);
                    writefile.Close();
                }
            }
            else
            {
                using (StreamWriter fileData = File.AppendText(TransactionFilePath))
                {
                    fileData.WriteLine(writeData);
                    fileData.Close();
                }
            }
        }
        //below methored created to update stock into text file.
        private void StockUpdate()
        {
            string[] StockProdArray = new string[displayListView.Items.Count];
            string[] StockSizeArray = new string[displayListView.Items.Count];

            // Data is storing into array
            for (int z = 0; z < displayListView.Items.Count; z++)
            {
                StockProdArray[z] = displayListView.Items[z].SubItems[0].Text;
                StockSizeArray[z] = displayListView.Items[z].SubItems[1].Text;
            }

            for (int x = 0; x < displayListView.Items.Count; x++)
            {
                switch (StockProdArray.GetValue(x))
                {
                    case "Whole Wheat":
                        StockItemIndex = 0;
                        break;
                    case "Everything":
                        StockItemIndex = 1;
                        break;
                    case "Blueberry":
                        StockItemIndex = 2;
                        break;
                    case "Chocolate Chip":
                        StockItemIndex = 3;
                        break;
                    case "Onion":
                        StockItemIndex = 4;
                        break;
                    case "Asiago":
                        StockItemIndex = 5;
                        break;
                    case "Salt":
                        StockItemIndex = 6;
                        break;
                    case "Poppy Seed":
                        StockItemIndex = 7;
                        break;
                    case "French Toast":
                        StockItemIndex = 8;
                        break;
                    case "Egg":
                        StockItemIndex = 9;
                        break;
                    case "Garlic":
                        StockItemIndex = 10;
                        break;
                    case "Sesame":
                        StockItemIndex = 11;
                        break;
                    case "Cheddar":
                        StockItemIndex = 12;
                        break;
                }

                for (int y = 0; y < displayListView.Items.Count; y++)
                {
                    switch (StockSizeArray.GetValue(y))
                    {
                        case "Small":
                            StockIndexSize = 0;
                            break;
                        case "Medium":
                            StockIndexSize = 1;
                            break;
                        case "Regular":
                            StockIndexSize = 2;
                            break;
                        case "Large":
                            StockIndexSize = 3;
                            break;
                        case "Extra Large":
                            StockIndexSize = 4;
                            break;
                    }
                }


                // saving the no of types from stock data
                int FirstCalculate = ArrayStock[StockItemIndex, StockIndexSize];
                int BagelQytSold = Convert.ToInt32(displayListView.Items[x].SubItems[2].Text);

                // below Calculating the pending stocks
                int StockPending = FirstCalculate - BagelQytSold;

                // Below saving the stocks
                ArrayStock[StockItemIndex, StockIndexSize] = StockPending;
                ArraySales[StockItemIndex, StockIndexSize] = BagelQytSold + ArraySales[StockItemIndex, StockIndexSize];



                // Below are checking the pending stocks
                if (StockPending < 0)
                {
                    int StockBackUp = StockPending - FirstCalculate;

                    MessageBox.Show("Not enough stock", "Error");
                    finalCost = 0;

                    DotFlag = false;
                }
                else
                {
                    ArrayStock[StockItemIndex, StockIndexSize] = StockPending;
                    DotFlag = true;
                }
            }

            
            File.WriteAllText(StockFilePath, string.Empty);
            StreamWriter streamWriter = File.AppendText(StockFilePath);

            // getting column titles in stock pending file.
            for (int c = 0; c < Bagelsizes.Length; c++)
            {
                streamWriter.Write("\t"  + Bagelsizes[c]);
                if (c == (Bagelsizes.Length - 1))
                {
                    streamWriter.WriteLine("\n");
                }
            }

            // getting row titles in stock pending file.
            for (int v = 0; v < BeagelNames.Length; v++)
            {
                streamWriter.Write(BeagelNames[v] + "\t");

                for (int l = 0; l < Bagelsizes.Length; l++)
                {
                    streamWriter.Write(ArrayStock[v, l] + "\t");
                }
                streamWriter.Write("\n");
            }
            streamWriter.Close();

            // Below are calculating to update ittems in Report
            File.WriteAllText(SalereportFilePath, string.Empty);
            StreamWriter SalesWriter = File.AppendText(SalereportFilePath);
            for (int i = 0; i < Bagelsizes.Length; i++)
            {
                SalesWriter.Write("\t");
                SalesWriter.Write(Bagelsizes[i]);

                if (i == Bagelsizes.Length - 1)
                {
                    SalesWriter.Write("\n");
                }
            }

            // Below are writing the colum and header and arry values in file
            for (int i = 0; i < BeagelNames.Length; i++)
            {
                SalesWriter.Write(BeagelNames[i] + "\t");
                for (int j = 0; j < Bagelsizes.Length; j++)
                {
                    SalesWriter.Write(ArraySales[i, j] + "\t");
                }
                SalesWriter.Write("\n");
            }
            SalesWriter.Close();

        }
        //once user seleted their order and added to card user can confrim the order by pressing order button and the order will be confired by popup.

        private void orderBtn_Click(object sender, EventArgs e)
        {
            //Checking the stocks
            StockUpdate();

            if (DotFlag == true)
            {
                //storing the transaction ID
                TrxID = getRandomTransactionNo();
                //Storing and getting Date
                string DT = DateTime.Now.ToString("MM/dd/yyyy");
                //Storing data into list
                BagelQty.Insert(0, DT);
                BagelQty.Insert(0, TrxID);
                BagelQty.Insert(BagelQty.Count, totalStoreCost.ToString("C"));
                string messagepopupString = string.Join("\n", BagelQty);
                MessageBox.Show("TheBagelShop" + "\n" + "\n" + "Transaction ID: "+ messagepopupString, "Confirmed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                orderData();
                
                //Below are the calculations for summary.
                Count++;
                tempTotalPrice+=finalCost;
                avgOverall=tempTotalPrice/Count;

                //Clearing the data once order is placed.
                displayListView.Items.Clear();
                bagelTypeListBox.ClearSelected();
                bagelSizeListBox.ClearSelected();
                qytNumericUpDown.Value=0;
                totalStoreCost=0;
                totalPriceLabel.Text="0";
                messagepopupString ="";
                BagelQty.Clear();






            }

        }
        //Pressing the stock data button Text fill will open to show the stocks are pending.
        private void stockDataBtn_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo = new ProcessStartInfo(StockFilePath);
            proc.Start();
        }   
        //Pressing clear buttong will clear all the form.
        private void clearBtn_Click(object sender, EventArgs e)
        {
            displayListView.Items.Clear();
            totalStoreCost=0;
            qytNumericUpDown.Value=0;
            bagelTypeListBox.ClearSelected();
            bagelSizeListBox.ClearSelected();
            totalPriceLabel.Text="0";
        }
        // Pressing Search button now from will open and I will give the open of searchs.
        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchForm Searchtransaction = new SearchForm();
            Searchtransaction.Show();
        }

        //Exit button pressing will close the applications.
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        //sales report will open on clicking the sale report button.
        private void saleReportBtn_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo = new ProcessStartInfo(SalereportFilePath);
            proc.Start();
        }
        //Compnay Summary will show in new form.
        private void summaryBtn_Click(object sender, EventArgs e)
        {
            SummayForm Summary = new SummayForm();
            Summary.Show();
        }

    }

}


    

