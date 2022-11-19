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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace MyBagelShop
{
    public partial class MyBagelShopApp : Form
    {
        public MyBagelShopApp()
        {
            InitializeComponent();
        }

        private static String[] BeagelNames = { "Whole Wheat", "Everything", "Insert", "Blueberry", "Chocolate Chip", "Onion", "Asiago", "Salt", "Poppy Seed", "French Toast", "Egg", "Garlic", "Sesame", "Cheddar" };
        const string PriceFilePath = "PricesBagelShop.txt";

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            StreamReader FileReader;
            //StreamReader sr = new StreamReader(PriceFilePath);
            using (FileReader= new StreamReader(PriceFilePath)) ;
            FileReader = File.OpenText(PriceFilePath);

        }
    }
}
