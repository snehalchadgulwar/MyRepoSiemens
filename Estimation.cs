using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace GoldEstimationApp
{
    public partial class Estimation : Form
    {
        public Estimation()
        {
            InitializeComponent();
        }
        private bool _PrevilegedCustomer;
        public bool PrevilegedCustomer
        {
            get => _PrevilegedCustomer;
            set => _PrevilegedCustomer = value;
        }
        private string _TotalAmount;
        public string TotalAmount
        {
            get => _TotalAmount;
            set => _TotalAmount = value;
        }
        public Estimation(bool isPrevileged)
        {
            InitializeComponent();
            PrevilegedCustomer = isPrevileged;
        }

        private void Estimation_Load(object sender, EventArgs e)
        {
            if (PrevilegedCustomer)
            {
                lblCustomerName.Text = "Welcome Previleged Customer";
                txtDiscount.Text = "2";
            }
            else
            {
                lblCustomerName.Text = "Welcome Regular Customer";
               
            }
            btnCalc.Enabled = false;
            btnPrintFile.Enabled = false;
            btnPrinttoScreen.Enabled = false;
            bnPrintPapr.Enabled = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try {
                    if (!string.IsNullOrEmpty(txtGoldPrice.Text) && !string.IsNullOrEmpty(txtWeight.Text))
                    {
                        double goldPrice = Convert.ToDouble(txtGoldPrice.Text.ToString());
                        double goldWeight = Convert.ToDouble(txtWeight.Text.ToString());
                        double totalPrice = goldPrice * goldWeight;
                        if (!string.IsNullOrEmpty(txtDiscount.Text))
                        {
                            double discount = totalPrice * (Convert.ToDouble(txtDiscount.Text.ToString()) / 100);
                            txtAmt.Text = (totalPrice - discount).ToString();
                            TotalAmount = txtAmt.Text;
                            btnPrintFile.Enabled = true;
                            btnPrinttoScreen.Enabled = true;
                            bnPrintPapr.Enabled = true;
                    }
                        else
                        {
                            txtAmt.Text = totalPrice.ToString();
                            TotalAmount = txtAmt.Text;
                            btnPrintFile.Enabled = true;
                            btnPrinttoScreen.Enabled = true;
                            bnPrintPapr.Enabled = true;
                    }
                    }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        private void txtGoldPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
            if (!string.IsNullOrEmpty(txtWeight.Text))
            {
                btnCalc.Enabled = true;
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
            if (!string.IsNullOrEmpty(txtGoldPrice.Text))
            {
                btnCalc.Enabled = true;
            }
        }

        private void btnPrinttoScreen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estimated Total Price for Gold " + TotalAmount);
        }

        private void btnPrintFile_Click(object sender, EventArgs e)
        {
            try {
                WriteEstimatetToFile(TotalAmount);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public static async Task WriteEstimatetToFile(string Amt)
        {
            try
            {
               // string path = @"C:\windows\Estimation.txt";
                await File.WriteAllTextAsync("Estimation.txt", "Total Calculated gold price is " + Amt);
                
                MessageBox.Show("file Estimation.txt created ");
                    }
            catch (Exception ex)
            {
                throw new IOException(ex.Message);
            }
            
        }

        private void bnPrintPapr_Click(object sender, EventArgs e)
        {
            PrintDialog dialgouge = new PrintDialog();
            dialgouge.ShowDialog();
            throw new NotImplementedException();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Parent.Enabled = true;
        }

        
    }
}
