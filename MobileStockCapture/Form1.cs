using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStockCapture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<string> mobilePhones = new List<string>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try {
                //string mobilePhone = mobilePhones.Add(txtCode.Text, txtMake.Text, int.Parse(txtQuantity.Text));
                if (string.IsNullOrEmpty(txtCode.Text) || string.IsNullOrEmpty(txtMake.Text) || string.IsNullOrEmpty(txtQuantity.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }
                lblOutput.Text = "Record Added.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        //public static string Add(string text1, string text2, int v)
        //{
        //    throw new NotImplementedException();
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (mobilePhones.Contains(txtCode.Text))
            {
                mobilePhones.Remove(txtCode.Text);
                lblOutput.Text = "Record Found.";
            }
            else
            {
                lblOutput.Text = "Record NOT Found.";
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (mobilePhones.Contains(txtCode.Text))
            {
                lblOutput.Text = "Record Deleted.";
            }
            else
            {
                lblOutput.Text = "Record NOT Found.";
            }
        }
    }
}
