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

        IDictionary<string, decimal> bagelPrices = new Dictionary<string, decimal>(){
            {"Whole Wheat Small", 3.5m},
            {"Whole Wheat Regular", 4.3m},
            {"Whole Wheat Medium", 4.8m},
            {"Whole Wheat Large", 5.3m},
            {"Whole Wheat Extra-Large", 6m}
        };

    private void addToCartBtn_Click(object sender, EventArgs e)
        {
            ItemGroupBox.Items.Add((prices[6,3].ToString("C2")));
            if(wholeWheatBtn.OnClick)
            {
                string bagelName = wholeWheatBtn.Text;
                Console.WriteLine(bagelName);
            }
            wholeWheatBtn.BackColor = Color.Red;
        }
    }
}
