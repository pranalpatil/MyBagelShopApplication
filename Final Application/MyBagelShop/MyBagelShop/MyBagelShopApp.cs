using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        // Declearing the Variables and storing the Names & Size in arrays
        decimal[,] FinalBagelprice = new decimal[13, 5];
        const string PriceFilePath = "PriceListBagel.txt";
        private static String[] BeagelNames = { "Whole Wheat", "Everything", "Blueberry", "Chocolate Chip", "Onion", "Asiago", "Salt", "Poppy Seed", "French Toast", "Egg", "Garlic", "Sesame", "Cheddar" };
        private static String[] Bagelsizes = { "Small", "Medium", "Regular", "Large", "Extra-Large " };
        int bagelTypeIndex = 0, bagelSizeIndex = 0, qytOrder=0;
        string SelectedBagel = "", SelectedSize = "";
        int SelectedSizs=0;
        decimal finalCost = 0;
        decimal totalStoreCost;

        
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
        // calling the file on form load. 
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
        }


        private void addToCartBtn_Click(object sender, EventArgs e)

        {

            if (bagelTypeListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select Bagel Type");
            }
            else if (bagelSizeListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select Bagel Size");
            }

            else if (qytNumericUpDown.Value <=0)
            {
                MessageBox.Show("Enter QYT");
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
                        totalStoreCost +=finalCost;
                        totalPriceLabel.Text= totalStoreCost.ToString("C2");

                        //ItemGroupBox.Items.Add(BeagelNames[bagelTypeIndex]+ "      "+qytOrder+ "    "+Bagelsizes[bagelSizeIndex]+ "    "+ finalCost.ToString("C2"));
                        ListViewItem Items=new ListViewItem(BeagelNames[bagelTypeIndex]);
                        Items.SubItems.Add(Bagelsizes[bagelSizeIndex]);
                        Items.SubItems.Add(qytOrder.ToString());
                        Items.SubItems.Add(finalCost.ToString("C2"));
                        displayListView.Items.Add(Items);

                    }
                }

                orderBtn.Enabled = true;

            }

        }

        private string getRandomTransactionNo()
        {
            string transactionNo;
            //int x = 0;
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
        private void orderBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to confirm with your Order?", "Order Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                    DateTime TimeSamay = DateTime.Now;
                    MessageBox.Show("TheBagelShop" + "\n" + "\n" + "Transaction ID: " + getRandomTransactionNo() + "\n" + "Date & Time: " + TimeSamay +
                    "\n" + "Bagel Name: " + BeagelNames[bagelTypeIndex] + "\n" + "Bagel Size: " + Bagelsizes[bagelSizeIndex]  +
                    "\n" + "Quantity: " + qytOrder + "\n" + "\n" + "Item Price: " + finalCost.ToString("C") +
                    "\n" + "Total Price: " + totalStoreCost.ToString("C"), "Confirmed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            displayListView.Items.Clear();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchForm Search = new SearchForm();
            Search.Show();
        }
    }
}


    

