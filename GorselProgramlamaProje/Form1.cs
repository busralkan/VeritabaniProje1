using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlamaProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();

            lblWarning.Text = "";

            if (email =="")
            {
                lblWarning.Text = "Lütfen E-posta adresinizi giriniz.";
                lblWarning.ForeColor = Color.Red;
                tbEmail.Focus();
                return;
            }

            if (password =="")
            {
                lblWarning.Text = "Lütfen parolanızı giriniz.";
                lblWarning.ForeColor = Color.Red;
                tbPassword.Focus();
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bttnTemizle_Click(object sender, EventArgs e)
        {
            lblWarning.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
            cbRemember.Checked = false;
        }
    }
}
