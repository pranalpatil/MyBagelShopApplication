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
                else if (counter == 2)
                {
                    bagelPricesDict.Add("Blueberry Small", Convert.ToDecimal(individualPrices[0]));
                    bagelPricesDict.Add("Blueberry Medium", Convert.ToDecimal(individualPrices[1]));
                    bagelPricesDict.Add("Blueberry Regular", Convert.ToDecimal(individualPrices[2]));
                    bagelPricesDict.Add("Blueberry Large", Convert.ToDecimal(individualPrices[3]));
                    bagelPricesDict.Add("Blueberry Extra-Large", Convert.ToDecimal(individualPrices[4]));
                }
                else if (counter == 3)
                {
                    bagelPricesDict.Add("Chocolate Chip Small", Convert.ToDecimal(individualPrices[0]));
                    bagelPricesDict.Add("Chocolate Chip Medium", Convert.ToDecimal(individualPrices[1]));
                    bagelPricesDict.Add("Chocolate Chip Regular", Convert.ToDecimal(individualPrices[2]));
                    bagelPricesDict.Add("Chocolate Chip Large", Convert.ToDecimal(individualPrices[3]));
                    bagelPricesDict.Add("Chocolate Chip Extra-Large", Convert.ToDecimal(individualPrices[4]));
                }
                else if (counter == 4)
                {
                    bagelPricesDict.Add("Onion Small", Convert.ToDecimal(individualPrices[0]));
                    bagelPricesDict.Add("Onion Medium", Convert.ToDecimal(individualPrices[1]));
                    bagelPricesDict.Add("Onion Regular", Convert.ToDecimal(individualPrices[2]));
                    bagelPricesDict.Add("Onion Large", Convert.ToDecimal(individualPrices[3]));
                    bagelPricesDict.Add("Onion Extra-Large", Convert.ToDecimal(individualPrices[4]));
                }
                else if (counter == 5)
                {
                    bagelPricesDict.Add("Asiago Small", Convert.ToDecimal(individualPrices[0]));
                    bagelPricesDict.Add("Asiago Medium", Convert.ToDecimal(individualPrices[1]));
                    bagelPricesDict.Add("Asiago Regular", Convert.ToDecimal(individualPrices[2]));
                    bagelPricesDict.Add("Asiago Large", Convert.ToDecimal(individualPrices[3]));
                    bagelPricesDict.Add("Asiago Extra-Large", Convert.ToDecimal(individualPrices[4]));
                }
                else if (counter == 6)
                {
                    bagelPricesDict.Add("Salt Small", Convert.ToDecimal(individualPrices[0]));
                    bagelPricesDict.Add("Salt Medium", Convert.ToDecimal(individualPrices[1]));
                    bagelPricesDict.Add("Salt Regular", Convert.ToDecimal(individualPrices[2]));
                    bagelPricesDict.Add("Salt Large", Convert.ToDecimal(individualPrices[3]));
                    bagelPricesDict.Add("Salt Extra-Large", Convert.ToDecimal(individualPrices[4]));
                }
                else if (counter == 7)
                {
                    bagelPricesDict.Add("Poppy Seed Small", Convert.ToDecimal(individualPrices[0]));
                    bagelPricesDict.Add("Poppy Seed Medium", Convert.ToDecimal(individualPrices[1]));
                    bagelPricesDict.Add("Poppy Seed Regular", Convert.ToDecimal(individualPrices[2]));
                    bagelPricesDict.Add("Poppy Seed Large", Convert.ToDecimal(individualPrices[3]));
                    bagelPricesDict.Add("Poppy Seed Extra-Large", Convert.ToDecimal(individualPrices[4]));
                }
                else if (counter == 8)
                {
                    bagelPricesDict.Add("French Toast Small", Convert.ToDecimal(individualPrices[0]));
                    bagelPricesDict.Add("French Toast Medium", Convert.ToDecimal(individualPrices[1]));
                    bagelPricesDict.Add("French Toast Regular", Convert.ToDecimal(individualPrices[2]));
                    bagelPricesDict.Add("French Toast Large", Convert.ToDecimal(individualPrices[3]));
                    bagelPricesDict.Add("French Toast Extra-Large", Convert.ToDecimal(individualPrices[4]));
                }
                else if (counter == 9)
                {
                    bagelPricesDict.Add("Egg Small", Convert.ToDecimal(individualPrices[0]));
                    bagelPricesDict.Add("Egg Medium", Convert.ToDecimal(individualPrices[1]));
                    bagelPricesDict.Add("Egg Regular", Convert.ToDecimal(individualPrices[2]));
                    bagelPricesDict.Add("Egg Large", Convert.ToDecimal(individualPrices[3]));
                    bagelPricesDict.Add("Egg Extra-Large", Convert.ToDecimal(individualPrices[4]));
                }
                else if (counter == 10)
                {
                    bagelPricesDict.Add("Garlic Small", Convert.ToDecimal(individualPrices[0]));
                    bagelPricesDict.Add("Garlic Medium", Convert.ToDecimal(individualPrices[1]));
                    bagelPricesDict.Add("Garlic Regular", Convert.ToDecimal(individualPrices[2]));
                    bagelPricesDict.Add("Garlic Large", Convert.ToDecimal(individualPrices[3]));
                    bagelPricesDict.Add("Garlic Extra-Large", Convert.ToDecimal(individualPrices[4]));
                }
                else if (counter == 11)
                {
                    bagelPricesDict.Add("Sesame Small", Convert.ToDecimal(individualPrices[0]));
                    bagelPricesDict.Add("Sesame Medium", Convert.ToDecimal(individualPrices[1]));
                    bagelPricesDict.Add("Sesame Regular", Convert.ToDecimal(individualPrices[2]));
                    bagelPricesDict.Add("Sesame Large", Convert.ToDecimal(individualPrices[3]));
                    bagelPricesDict.Add("Sesame Extra-Large", Convert.ToDecimal(individualPrices[4]));
                }
                else if (counter == 12)
                {
                    bagelPricesDict.Add("Cheddar Small", Convert.ToDecimal(individualPrices[0]));
                    bagelPricesDict.Add("Cheddar Medium", Convert.ToDecimal(individualPrices[1]));
                    bagelPricesDict.Add("Cheddar Regular", Convert.ToDecimal(individualPrices[2]));
                    bagelPricesDict.Add("Cheddar Large", Convert.ToDecimal(individualPrices[3]));
                    bagelPricesDict.Add("Cheddar Extra-Large", Convert.ToDecimal(individualPrices[4]));
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
        

        

        private void wholeWheatBtn_Click(object sender, EventArgs e)
        {
            button1Clicked = true;
            bagelType = "Whole Wheat";
        }
        private void everythingBtn_Click(object sender, EventArgs e)
        {
            button1Clicked = true;
            bagelType = "Everything";
        }
        private void blueberryBtn_Click(object sender, EventArgs e)
        {

            button1Clicked = true;
            bagelType = "Blueberry";

        }
        private void chocolateChipBtn_Click(object sender, EventArgs e)
        {
            button1Clicked = true;
            bagelType = "Chocolate Chip";
        }
        private void cheddarBtn_Click(object sender, EventArgs e)
        {
            button1Clicked = true;
            bagelType = "Cheddar"; 
        }
        private void asiagoBtn_Click(object sender, EventArgs e)
        {
            button1Clicked = true;
            bagelType = "Asiago";

        }
        private void saltBtn_Click(object sender, EventArgs e)
        {
            button1Clicked = true;
            bagelType = "Salt";

        }
        private void poppySeedBtn_Click(object sender, EventArgs e)
        {
            button1Clicked = true;
            bagelType = "Poppy Seed";

        }
        private void frenchToastBtn_Click(object sender, EventArgs e)
        {
            button1Clicked = true;
            bagelType = "French Toast";
        }
        private void eggBtn_Click(object sender, EventArgs e)
        {
            button1Clicked = true;
            bagelType = "Egg";
        }
        private void garlicBtn_Click(object sender, EventArgs e)
        {
            button1Clicked = true;
            bagelType = "Garlic";
        }
        private void sesameBtn_Click(object sender, EventArgs e)
        {
            button1Clicked = true;
            bagelType = "Sesame";
        }
        private void onionBtn_Click(object sender, EventArgs e)
        {
            button1Clicked = true;
            bagelType = "Onion";
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
        private void regularSizeBtn_Click(object sender, EventArgs e)
        {
            button2Clicked = true;
            bagelSize = "Regular";

        }
        private void largeSizeBtn_Click(object sender, EventArgs e)
        {
            button2Clicked = true;
            bagelSize = "Large";

        }
        private void extraLargeSizeBtn_Click(object sender, EventArgs e)
        {
            button2Clicked = true;
            bagelSize = "Extra-Large";

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

        
    }
}
