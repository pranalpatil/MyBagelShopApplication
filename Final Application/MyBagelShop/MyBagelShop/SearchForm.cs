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
    public partial class SearchForm : Form
    {
        //Below are variables created and reader as well.
        StreamReader lineread;
        string Temp;
        string[] TrxSplit;
        string[] TrxSplitDate;
        string valueSearch;
        const string TransactionFilePath = "TransactionData.txt";


        public SearchForm()
        {
            InitializeComponent();
        }
        //created an method to search transaction by Id
        private void SearchID (string Searchdata, string transaction)
        {
            string data;
            if (File.Exists(TransactionFilePath))
            {
                searchResultListBox.Items.Clear();

                lineread=File.OpenText(TransactionFilePath);
                string[] text=File.ReadAllLines(transaction);

                foreach (string p in text)
                {
                    data = lineread.ReadLine();
                    if (data != null)
                    {
                        if (data.Contains(Searchdata))
                        {
                            TrxSplit = data.Split(',');
                            for (int t = 0; t < TrxSplit.Length; t++)
                            {
                                TrxSplit[t] = TrxSplit[t].Trim();
                                searchResultListBox.Items.Add(TrxSplit[t]);
                            }
                            

                        }

                    }
                }
                lineread.Close();

            }
            else
            {
                
                MessageBox.Show("Data has been bot found","Error");
            }
        }
        //created an method to search transaction by date

        private void SearchDate(string Searchdata, string transaction)
        {

            if (File.Exists(TransactionFilePath))

            {
                searchResultListBox.Items.Clear();
                lineread = File.OpenText(TransactionFilePath);
                string[] Date = File.ReadAllLines(transaction);
               

                foreach (string i in Date)
                {
                    string datepoint = lineread.ReadLine();
                    if (datepoint != null)
                    {
                        if (datepoint.Contains(Searchdata))
                        {
                            //SearchlistBox.Items.Add(dateline);
                            TrxSplitDate = datepoint.Split(',');
                            for (int p = 0; p < TrxSplitDate.Length; p++)
                            {
                                TrxSplitDate[p] = TrxSplitDate[p].Trim();
                                searchResultListBox.Items.Add(TrxSplitDate[p]);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter Date to seaech");
                        break;
                    }
                }
                lineread.Close();
            }
            else
            {
                MessageBox.Show("Data has been bot found","Error");
            }

        }
        //application will close by pressing exit button,
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // On click the search button the values will show into list box.
        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (transactionNoRadioButton.Checked)
            {
                if (searchInputTextBox.Text!=null)
                {
                    valueSearch=searchInputTextBox.Text;
                    SearchID(valueSearch, TransactionFilePath);
                }
                else
                {
                    MessageBox.Show("Enter Transaction ID", "Error");

                }
            }
            else if (dateRadioButton.Checked)
            {
                valueSearch=searchInputTextBox.Text;
                SearchDate(valueSearch, TransactionFilePath);
            }
            else
            {
                MessageBox.Show("Enter Transaction ID", "Error");

            }
        }
        // clearing thesearch form if user need to search another transaction.
        private void clearSearchBtn_Click(object sender, EventArgs e)
        {
            searchResultListBox.Items.Clear();
            dateRadioButton.Checked=false;
            transactionNoRadioButton.Checked=false;
            searchInputTextBox.Text="";
            searchbutton.Enabled=true;
        }
    }
}
