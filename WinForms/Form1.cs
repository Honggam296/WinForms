using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "admin";
            if (user.Equals(txtUserName.Text) && pass.Equals(txtPassword.Text))
            {
                MessageBox.Show("Dang nhap thanh cong");
                form2 f = new form2();
                //f.MdiParent = this;
                f.Show();


            }
            else
                MessageBox.Show("Dang nhap that bai");
        }
    }
}
