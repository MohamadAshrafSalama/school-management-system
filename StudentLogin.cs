using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system
{
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void StudenRegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentRegister student = new StudentRegister();
            student.Show();
        }

        private void StudentLoginButton_Click(object sender, EventArgs e)
        {
                GlobalData.CurrntStuden= GlobalData.LoginStudent(this.username.Text, Convert.ToInt32(this.password.Text));
            if (GlobalData.CurrntStuden == 100)
            {
                MessageBox.Show("Wrong Username or Psasword");
            }
            else
            {
                this.Hide();
                Sudent sudent = new Sudent();
                sudent.Show();
            }
            
        }

        private void StudentLogin_Load(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
