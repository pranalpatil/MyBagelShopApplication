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
        // exiting the form once clicking the Exit button.
        private void exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
        // On form load all the required summary will show in labels.
        private void SummayForm_Load(object sender, EventArgs e)
        {
            //Showing total numbers of Bagel sold.
            totalBagelDisplaylabel.Text= MyBagelShopApp.BagelOverall.ToString();
            //Showing total price on company transaction.
            TotalSaleDisplayLabel.Text= MyBagelShopApp.tempTotalPrice.ToString("C");
            //showing the number to total transaction has been done.
            totalTransactionDisplayLabel.Text= MyBagelShopApp.Count.ToString();
            //showing the avrage value of company.
            AverageDisplayLabel.Text= MyBagelShopApp.avgOverall.ToString("C");
        }
    }
}
