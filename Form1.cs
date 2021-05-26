using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace GoldEstimationApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text)|| string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Please enter Username or Password");
            }
            else
            {
                XDocument xdoc = XDocument.Load(@"C:\Users\admin\source\repos\GoldEstimationApp\Users.xml");
                IEnumerable<XElement> users = xdoc.Root.Elements();
                bool isValidCustomer = false;
                foreach (var user in users)
                {
                    if (user.Element("Name").Value == txtUser.Text &&
                        user.Element("Password").Value == txtPass.Text)
                    {
                        if (user.Element("IsPrevileged").Value == "Yes")
                        {

                            Estimation est = new Estimation(true);
                            est.ShowDialog();
                        }
                        else
                        {

                            Estimation est = new Estimation(false);
                            est.ShowDialog();
                        }
                        isValidCustomer = true;
                        break;
                    }
                }
                if (!isValidCustomer)
                {
                    MessageBox.Show("Please enter valid credentials");
                }
            }
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUser.Text) && !string.IsNullOrEmpty(txtPass.Text))
            {
                btnSubmit.Enabled = true;
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtPass.Text) && !string.IsNullOrEmpty(txtUser.Text))
            {
                btnSubmit.Enabled = true;
            }
        }
    }
}
