using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBagelShop
{
    public partial class SummayForm : Form
    {
        public SummayForm()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SummayForm_Load(object sender, EventArgs e)
        {
            totalBagelDisplaylabel.Text= MyBagelShopApp.BagelOverall.ToString();
            TotalSaleDisplayLabel.Text= MyBagelShopApp.tempTotalPrice.ToString("C");
            totalTransactionDisplayLabel.Text= MyBagelShopApp.Count.ToString();
            AverageDisplayLabel.Text= MyBagelShopApp.avgOverall.ToString("C");
        }
    }
}
