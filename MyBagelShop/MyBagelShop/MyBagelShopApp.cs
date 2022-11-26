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
        public class qytValidity : Exception
        {
            public qytValidity(string message) : base(message)
            {
            }
        }
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
        const string TrxRecord = "Transactions.txt";
        int trxNo = 0;
        




        private void wholeWheatBtn_Click(object sender, EventArgs e)
        {
            everythingBtn.BackColor=Color.White;
            blueberryBtn.BackColor=Color.White;
            chocolateChipBtn.BackColor=Color.White;
            onionBtn.BackColor=Color.White;
            asiagoBtn.BackColor=Color.White;
            saltBtn.BackColor=Color.White;
            poppySeedBtn.BackColor=Color.White;
            frenchToastBtn.BackColor=Color.White;
            eggBtn.BackColor=Color.White;
            garlicBtn.BackColor=Color.White;
            sesameBtn.BackColor=Color.White;
            cheddarBtn.BackColor=Color.White;
            button1Clicked = true;
            wholeWheatBtn.BackColor=Color.Cyan;
            

            bagelType = "Whole Wheat";


            
            //button1Clicked = false;
            //wholeWheatBtn.BackColor=DefaultBackColor;
            //wholeWheatBtn.Enabled = false;
        }
        private void everythingBtn_Click(object sender, EventArgs e)
        {
            wholeWheatBtn.BackColor=Color.White;
            blueberryBtn.BackColor=Color.White;
            chocolateChipBtn.BackColor=Color.White;
            onionBtn.BackColor=Color.White;
            asiagoBtn.BackColor=Color.White;
            saltBtn.BackColor=Color.White;
            poppySeedBtn.BackColor=Color.White;
            frenchToastBtn.BackColor=Color.White;
            eggBtn.BackColor=Color.White;
            garlicBtn.BackColor=Color.White;
            sesameBtn.BackColor=Color.White;
            cheddarBtn.BackColor=Color.White;
            button1Clicked = true;
            everythingBtn.BackColor=Color.Cyan;
            

            bagelType = "Everything";
        }
        private void blueberryBtn_Click(object sender, EventArgs e)
        {

            wholeWheatBtn.BackColor=Color.White;
            chocolateChipBtn.BackColor=Color.White;
            onionBtn.BackColor=Color.White;
            asiagoBtn.BackColor=Color.White;
            saltBtn.BackColor=Color.White;
            poppySeedBtn.BackColor=Color.White;
            frenchToastBtn.BackColor=Color.White;
            eggBtn.BackColor=Color.White;
            garlicBtn.BackColor=Color.White;
            sesameBtn.BackColor=Color.White;
            cheddarBtn.BackColor=Color.White;
            everythingBtn.BackColor=Color.White;
            button1Clicked = true;
            blueberryBtn.BackColor=Color.Cyan;
            bagelType = "Blueberry";

        }
        private void chocolateChipBtn_Click(object sender, EventArgs e)
        {
            wholeWheatBtn.BackColor=Color.White;
            onionBtn.BackColor=Color.White;
            asiagoBtn.BackColor=Color.White;
            saltBtn.BackColor=Color.White;
            poppySeedBtn.BackColor=Color.White;
            frenchToastBtn.BackColor=Color.White;
            eggBtn.BackColor=Color.White;
            garlicBtn.BackColor=Color.White;
            sesameBtn.BackColor=Color.White;
            cheddarBtn.BackColor=Color.White;
            everythingBtn.BackColor=Color.White;
            blueberryBtn.BackColor=Color.White;
            button1Clicked = true;
            chocolateChipBtn.BackColor=Color.Cyan;
            bagelType = "Chocolate Chip";
        }
        private void cheddarBtn_Click(object sender, EventArgs e)
        {
            wholeWheatBtn.BackColor=Color.White;
            chocolateChipBtn.BackColor=Color.White;
            onionBtn.BackColor=Color.White;
            asiagoBtn.BackColor=Color.White;
            saltBtn.BackColor=Color.White;
            poppySeedBtn.BackColor=Color.White;
            frenchToastBtn.BackColor=Color.White;
            eggBtn.BackColor=Color.White;
            garlicBtn.BackColor=Color.White;
            sesameBtn.BackColor=Color.White;
            blueberryBtn.BackColor=Color.White;
            everythingBtn.BackColor=Color.White;
            button1Clicked = true;
            cheddarBtn.BackColor=Color.Cyan;
            bagelType = "Cheddar"; 
        }
        private void asiagoBtn_Click(object sender, EventArgs e)
        {
            wholeWheatBtn.BackColor=Color.White;
            chocolateChipBtn.BackColor=Color.White;
            onionBtn.BackColor=Color.White;
            blueberryBtn.BackColor=Color.White;
            saltBtn.BackColor=Color.White;
            poppySeedBtn.BackColor=Color.White;
            frenchToastBtn.BackColor=Color.White;
            eggBtn.BackColor=Color.White;
            garlicBtn.BackColor=Color.White;
            sesameBtn.BackColor=Color.White;
            cheddarBtn.BackColor=Color.White;
            everythingBtn.BackColor=Color.White;
            button1Clicked = true;
            asiagoBtn.BackColor=Color.Cyan;
            bagelType = "Asiago";

        }
        private void saltBtn_Click(object sender, EventArgs e)
        {
            wholeWheatBtn.BackColor=Color.White;
            chocolateChipBtn.BackColor=Color.White;
            onionBtn.BackColor=Color.White;
            asiagoBtn.BackColor=Color.White;
            blueberryBtn.BackColor=Color.White;
            poppySeedBtn.BackColor=Color.White;
            frenchToastBtn.BackColor=Color.White;
            eggBtn.BackColor=Color.White;
            garlicBtn.BackColor=Color.White;
            sesameBtn.BackColor=Color.White;
            cheddarBtn.BackColor=Color.White;
            everythingBtn.BackColor=Color.White;
            button1Clicked = true;
            saltBtn.BackColor=Color.Cyan;
            bagelType = "Salt";

        }
        private void poppySeedBtn_Click(object sender, EventArgs e)
        {
            wholeWheatBtn.BackColor=Color.White;
            chocolateChipBtn.BackColor=Color.White;
            onionBtn.BackColor=Color.White;
            asiagoBtn.BackColor=Color.White;
            saltBtn.BackColor=Color.White;
            blueberryBtn.BackColor=Color.White;
            frenchToastBtn.BackColor=Color.White;
            eggBtn.BackColor=Color.White;
            garlicBtn.BackColor=Color.White;
            sesameBtn.BackColor=Color.White;
            cheddarBtn.BackColor=Color.White;
            everythingBtn.BackColor=Color.White;
            button1Clicked = true;
            poppySeedBtn.BackColor=Color.Cyan;
            bagelType = "Poppy Seed";

        }
        private void frenchToastBtn_Click(object sender, EventArgs e)
        {
            wholeWheatBtn.BackColor=Color.White;
            chocolateChipBtn.BackColor=Color.White;
            onionBtn.BackColor=Color.White;
            asiagoBtn.BackColor=Color.White;
            saltBtn.BackColor=Color.White;
            poppySeedBtn.BackColor=Color.White;
            blueberryBtn.BackColor=Color.White;
            eggBtn.BackColor=Color.White;
            garlicBtn.BackColor=Color.White;
            sesameBtn.BackColor=Color.White;
            cheddarBtn.BackColor=Color.White;
            everythingBtn.BackColor=Color.White;
            button1Clicked = true;
            frenchToastBtn.BackColor=Color.Cyan;
            bagelType = "French Toast";
        }
        private void eggBtn_Click(object sender, EventArgs e)
        {
            wholeWheatBtn.BackColor=Color.White;
            chocolateChipBtn.BackColor=Color.White;
            onionBtn.BackColor=Color.White;
            asiagoBtn.BackColor=Color.White;
            saltBtn.BackColor=Color.White;
            poppySeedBtn.BackColor=Color.White;
            frenchToastBtn.BackColor=Color.White;
            blueberryBtn.BackColor=Color.White;
            garlicBtn.BackColor=Color.White;
            sesameBtn.BackColor=Color.White;
            cheddarBtn.BackColor=Color.White;
            everythingBtn.BackColor=Color.White;
            button1Clicked = true;
            eggBtn.BackColor=Color.Cyan;
            bagelType = "Egg";
        }
        private void garlicBtn_Click(object sender, EventArgs e)
        {
            wholeWheatBtn.BackColor=Color.White;
            chocolateChipBtn.BackColor=Color.White;
            onionBtn.BackColor=Color.White;
            asiagoBtn.BackColor=Color.White;
            saltBtn.BackColor=Color.White;
            poppySeedBtn.BackColor=Color.White;
            frenchToastBtn.BackColor=Color.White;
            eggBtn.BackColor=Color.White;
            blueberryBtn.BackColor=Color.White;
            sesameBtn.BackColor=Color.White;
            cheddarBtn.BackColor=Color.White;
            everythingBtn.BackColor=Color.White;
            button1Clicked = true;
            garlicBtn.BackColor=Color.Cyan;
            bagelType = "Garlic";
        }
        private void sesameBtn_Click(object sender, EventArgs e)
        {
            wholeWheatBtn.BackColor=Color.White;
            chocolateChipBtn.BackColor=Color.White;
            onionBtn.BackColor=Color.White;
            asiagoBtn.BackColor=Color.White;
            saltBtn.BackColor=Color.White;
            poppySeedBtn.BackColor=Color.White;
            frenchToastBtn.BackColor=Color.White;
            eggBtn.BackColor=Color.White;
            garlicBtn.BackColor=Color.White;
            blueberryBtn.BackColor=Color.White;
            cheddarBtn.BackColor=Color.White;
            everythingBtn.BackColor=Color.White;
            button1Clicked = true;
            sesameBtn.BackColor=Color.Cyan;
            bagelType = "Sesame";
        }
        private void onionBtn_Click(object sender, EventArgs e)
        {
            wholeWheatBtn.BackColor=Color.White;
            chocolateChipBtn.BackColor=Color.White;
            blueberryBtn.BackColor=Color.White;
            asiagoBtn.BackColor=Color.White;
            saltBtn.BackColor=Color.White;
            poppySeedBtn.BackColor=Color.White;
            frenchToastBtn.BackColor=Color.White;
            eggBtn.BackColor=Color.White;
            garlicBtn.BackColor=Color.White;
            sesameBtn.BackColor=Color.White;
            cheddarBtn.BackColor=Color.White;
            everythingBtn.BackColor=Color.White;
            button1Clicked = true;
            onionBtn.BackColor=Color.Cyan;
            bagelType = "Onion";
        }
        private void smallSizeBtn_Click(object sender, EventArgs e)
        {
            mediumSizeBtn.BackColor=Color.White;
            regularSizeBtn.BackColor=Color.White;
            largeSizeBtn.BackColor=Color.White;
            extraLargeSizeBtn.BackColor=Color.White;
            button2Clicked = true;
            smallSizeBtn.BackColor=Color.Yellow;
            bagelSize = "Small";
        }
        private void mediumSizeBtn_Click(object sender, EventArgs e)
        {
            smallSizeBtn.BackColor=Color.White;
            regularSizeBtn.BackColor=Color.White;
            largeSizeBtn.BackColor=Color.White;
            extraLargeSizeBtn.BackColor=Color.White;
            button2Clicked = true;
            mediumSizeBtn.BackColor=Color.Yellow;
            bagelSize = "Medium";
        }
        private void regularSizeBtn_Click(object sender, EventArgs e)
        {
            smallSizeBtn.BackColor=Color.White;
            regularSizeBtn.BackColor=Color.White;
            largeSizeBtn.BackColor=Color.White;
            extraLargeSizeBtn.BackColor=Color.White;
            button2Clicked = true;
            regularSizeBtn.BackColor=Color.Yellow;
            bagelSize = "Regular";

        }
        private void largeSizeBtn_Click(object sender, EventArgs e)
        {
            mediumSizeBtn.BackColor=Color.White;
            regularSizeBtn.BackColor=Color.White;
            smallSizeBtn.BackColor=Color.White;
            extraLargeSizeBtn.BackColor=Color.White;
            button2Clicked = true;
            largeSizeBtn.BackColor=Color.Yellow;
            bagelSize = "Large";

        }
        private void extraLargeSizeBtn_Click(object sender, EventArgs e)
        {
            mediumSizeBtn.BackColor=Color.White;
            regularSizeBtn.BackColor=Color.White;
            largeSizeBtn.BackColor=Color.White;
            smallSizeBtn.BackColor=Color.White;
            button2Clicked = true;
            extraLargeSizeBtn.BackColor=Color.Yellow;
            bagelSize = "Extra-Large";

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
        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            //if (button1Clicked == true && button2Clicked == true)
            //{
            //    fetchBagelPrice = bagelType + " " + bagelSize;
            //    decimal bagelPrice = bagelPricesDict[fetchBagelPrice];
            //    totalPrice += bagelPricesDict[fetchBagelPrice];
            //    Console.WriteLine(totalPrice);

            //    ItemGroupBox.Items.Add(bagelType + ", " + bagelSize + ", " + bagelPrice.ToString("C2"));
            //}
            //else
            //{
            //    MessageBox.Show("show");
            //}
            if (button1Clicked == true )
            {
                if (button2Clicked == true)

                {
                    
                    
                    fetchBagelPrice = bagelType + " " + bagelSize;

                    decimal bagelPrice = bagelPricesDict[fetchBagelPrice];
                    totalPrice += bagelPricesDict[fetchBagelPrice];
                    Console.WriteLine(totalPrice);
                    ItemGroupBox.Items.Add(bagelType + ", " + bagelSize + ", " + bagelPrice.ToString("C2"));

                    totalDisplayLabel.Text=totalPrice.ToString("C2");
                    wholeWheatBtn.BackColor=Color.White;
                    chocolateChipBtn.BackColor=Color.White;
                    blueberryBtn.BackColor=Color.White;
                    asiagoBtn.BackColor=Color.White;
                    saltBtn.BackColor=Color.White;
                    poppySeedBtn.BackColor=Color.White;
                    frenchToastBtn.BackColor=Color.White;
                    eggBtn.BackColor=Color.White;
                    garlicBtn.BackColor=Color.White;
                    sesameBtn.BackColor=Color.White;
                    cheddarBtn.BackColor=Color.White;
                    everythingBtn.BackColor=Color.White;
                    onionBtn.BackColor=Color.White;
                    mediumSizeBtn.BackColor=Color.White;
                    regularSizeBtn.BackColor=Color.White;
                    largeSizeBtn.BackColor=Color.White;
                    smallSizeBtn.BackColor=Color.White;
                    extraLargeSizeBtn.BackColor=Color.White;



                    

                }
                else
                {

                    MessageBox.Show("Please Select Size");
                }

            }
            else
            {
                MessageBox.Show("Please Select Bagel Type");
            }

            
            
            
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ItemGroupBox.Items.Clear();
            totalDisplayLabel.Text="";
            totalPrice=0;
            wholeWheatBtn.BackColor=Color.White;
            chocolateChipBtn.BackColor=Color.White;
            blueberryBtn.BackColor=Color.White;
            asiagoBtn.BackColor=Color.White;
            saltBtn.BackColor=Color.White;
            poppySeedBtn.BackColor=Color.White;
            frenchToastBtn.BackColor=Color.White;
            eggBtn.BackColor=Color.White;
            garlicBtn.BackColor=Color.White;
            sesameBtn.BackColor=Color.White;
            cheddarBtn.BackColor=Color.White;
            everythingBtn.BackColor=Color.White;
            onionBtn.BackColor=Color.White;
            mediumSizeBtn.BackColor=Color.White;
            regularSizeBtn.BackColor=Color.White;
            largeSizeBtn.BackColor=Color.White;
            smallSizeBtn.BackColor=Color.White;
            extraLargeSizeBtn.BackColor=Color.White;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchTrx Search = new searchTrx();
            Search.Show();
        }

        
        private void orderBtn_Click(object sender, EventArgs e)
        {
            DateTime DT = DateTime.Now;
            StreamWriter write = File.AppendText(TrxRecord);
            using (write)
            {
                write.WriteLine(getRandomTransactionNo()+DT+bagelType+bagelSize);
                write.WriteLine(ItemGroupBox.Items.ToString()); 
                //write.WriteLine(bagelType);
                //write.WriteLine(bagelSize);
                //write.WriteLine(phoneNumberTextBox.Text);// Storing the Phone Number
                //write.WriteLine(investmentAmountTextBox.Text);// Storing the investment amount
                //write.WriteLine(emiSwitch); // Storing the EMI 
                //write.WriteLine(yearSwitch*12); // Storing the Year of loan
                //write.WriteLine(totalRepaymentsSwitch);// Storing the Total Repayments
                //write.WriteLine(rate); // Storing the Interest

            }
        }
    }
}
