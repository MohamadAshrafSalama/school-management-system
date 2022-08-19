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
    public partial class teacher_new_registration : Form
    {
        public teacher_new_registration()
        {
            InitializeComponent();
        }

        private void year_TextChanged(object sender, EventArgs e)
        {

        }

        private void month_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Teatcher teatcher = new Teatcher(this.username.Text, Convert.ToInt32(this.password.Text), this.name.Text, Convert.ToInt32(this.year.Text), Convert.ToInt32(this.month.Text), Convert.ToInt32(this.day.Text), this.nationalty.Text, this.adress.Text, this.gender.Text);
            GlobalData.AddTeatcher(teatcher);
            teacher teacher = new teacher();
            teacher.Show();
            this.Hide();
            
        }
    }
}
