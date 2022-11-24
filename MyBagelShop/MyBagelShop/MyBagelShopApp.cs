using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace MyBagelShop
{

    
    public partial class MyBagelShopApp : Form
    {
        IDictionary<string, decimal> bagelPricesDict = new Dictionary<string, decimal>();
        public MyBagelShopApp()
        {
            
            InitializeComponent();

            var fs = new FileStream(PriceFilePath, FileMode.Open, FileAccess.Read);
            var price = new StreamReader(fs, Encoding.UTF8);
            
            StreamReader priceData = File.OpenText(PriceFilePath);
            string bagelPrices = priceData.ReadToEnd();

            //Console.WriteLine(bagelPrices);
            string[] bagelPriceList = bagelPrices.Split(new[] {"\n"}, StringSplitOptions.None);
            int counter = 0;
            foreach (string bagel in bagelPriceList)
            {
                Console.WriteLine(bagel);
                string[] individualPrices = bagel.Split(new[] { "," }, StringSplitOptions.None);

                if (counter == 0)
                {
                    bagelPricesDict.Add("Whole Wheat Small", Convert.ToDecimal(individualPrices[0]));
                    bagelPricesDict.Add("Whole Wheat Medium", Convert.ToDecimal(individualPrices[1]));
                    bagelPricesDict.Add("Whole Wheat Regular", Convert.ToDecimal(individualPrices[2]));
                    bagelPricesDict.Add("Whole Wheat Large", Convert.ToDecimal(individualPrices[3]));
                    bagelPricesDict.Add("Whole Wheat Extra-Large", Convert.ToDecimal(individualPrices[4]));
                }

                else if (counter == 1)
                {
                    bagelPricesDict.Add("Everything Small", Convert.ToDecimal(individualPrices[0]));
                    bagelPricesDict.Add("Everything Medium", Convert.ToDecimal(individualPrices[1]));
                    bagelPricesDict.Add("Everything Regular", Convert.ToDecimal(individualPrices[2]));
                    bagelPricesDict.Add("Everything Large", Convert.ToDecimal(individualPrices[3]));
                    bagelPricesDict.Add("Everything Extra-Large", Convert.ToDecimal(individualPrices[4]));
                }


                counter++;
            }
        }

        public static bool button1Clicked = false;
        public static bool button2Clicked = false;

        public static string bagelType;
        public static string bagelSize;
        public static string fetchBagelPrice;

        public static decimal totalPrice = 0.0m;


        private static String[] BeagelNames = { "Whole Wheat", "Everything", "Insert", "Blueberry", "Chocolate Chip", "Onion", "Asiago", "Salt", "Poppy Seed", "French Toast", "Egg", "Garlic", "Sesame", "Cheddar" };
        const string PriceFilePath = "PriceListBagel.txt";
        Decimal wholeWheattotal,everythingtotal;

        decimal[,] prices =
        {
            {3.5m,4.3m,4.8m,5.3m,6m},               //Row 0   
            {3.8m,4.44m,5.6m,5.8m,6.32m},           //Row 1
            {4.2m,4.89m,5.3m,6.65m,7m},             //Row 2
            {3.5m,4.6m,5.4m,5.89m,7.33m},           //Row 3
            {2.99m,4.43m,5.67m,6.8m,7.2m},          //Row 4
            {3.5m,4.7m,5.7m,7.22m,8.43m},           //Row 5
            {4.2m,5.4m,6.89m,7.66m,8.22m},          //Row 6
            {3.5m,4.89m,5.56m,6.5m,7.45m},          //Row 7
            {2.7m,4.3m,5.76m,7.45m,9.45m},          //Row 8
            {3.57m,4.6m,6.5m,7.89m,8.99m},          //Row 9
            {2.99m,3.59m,4.23m,6.23m,7.99m},        //Row 10
            {3.5m,4.3m,6.56m,7.67m,8.33m},          //Row 11
            {4.2m,5.55m,6.45m,8.15m,10.99m}         //Row 12

        };
        

        

        private void wholeWheatBtn_Click(object sender, EventArgs e)
        {
            button1Clicked = true;
            bagelType = "Whole Wheat";
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            if (button1Clicked == true && button2Clicked == true)
            {
                fetchBagelPrice = bagelType + " " + bagelSize;
                decimal bagelPrice = bagelPricesDict[fetchBagelPrice];
                totalPrice += bagelPricesDict[fetchBagelPrice];
                Console.WriteLine(totalPrice);

                ItemGroupBox.Items.Add(bagelType + ", " + bagelSize + ", " + bagelPrice.ToString("C2"));
            }
        }

        private void smallSizeBtn_Click(object sender, EventArgs e)
        {
            button2Clicked = true;
            bagelSize = "Small";
        }

        private void mediumSizeBtn_Click(object sender, EventArgs e)
        {
            button2Clicked = true;
            bagelSize = "Medium";
        }

        private void everythingBtn_Click(object sender, EventArgs e)
        {
            button1Clicked = true;
            bagelType = "Everything";
        }
    }
}
