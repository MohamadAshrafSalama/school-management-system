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
    public partial class mangerLogin : Form
    {
        public mangerLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text== GlobalData.manger.UserName && Convert.ToInt32(this.textBox2.Text) == GlobalData.manger.Password)
            {
                manger_form manger_Form = new manger_form();
                manger_Form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("wrong username and password");
            }
        }
    }
}
