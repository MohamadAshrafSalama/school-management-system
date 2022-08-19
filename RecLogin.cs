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
    public partial class RecLogin : Form
    {
        public RecLogin()
        {
            InitializeComponent();
        }

        private void RecLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalData.CurrntReceptionist = GlobalData.LoginReceptionist(this.textBox1.Text, Convert.ToInt32(this.textBox2.Text));
            if (GlobalData.CurrntReceptionist == 100)
            {
                MessageBox.Show("Wrong Username and Password");
            }
            else
            {
                receptionist receptionist = new receptionist();
                receptionist.Show();
                this.Hide();
            }
        }

        private void teacherRegisterButton_Click(object sender, EventArgs e)
        {

        }
    }
}
