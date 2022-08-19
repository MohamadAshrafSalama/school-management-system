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
    public partial class teacher : Form
    {
        public teacher()
        {
            InitializeComponent();
        }

        private void teacher_Load(object sender, EventArgs e)
        {

        }
        
        private void teacherRegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacher_new_registration teacher_New_Registration = new teacher_new_registration();
            teacher_New_Registration.Show();


        }
        private void TeacherRegisterButton_Click(object sender, EventArgs e)
        {
            GlobalData.CurrntTeacher = GlobalData.LoginTeatcher(this.UserName.Text, Convert.ToInt32(this.Password.Text));
            this.Hide();
            teacher y  = new teacher();
            y.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalData.CurrntTeacher = GlobalData.LoginTeatcher(this.textBox1.Text,Convert.ToInt32(this.textBox2.Text));

            if (GlobalData.CurrntTeacher == 100)
            {
                MessageBox.Show("Wrong Username and Password");
            }
            else
            {
                teacher_data_for_assigment teacher_Data_For_Assigment = new teacher_data_for_assigment();
                teacher_Data_For_Assigment.Show();
                this.Hide();
            }
        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }
    }
}
