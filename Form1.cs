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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecLogin recLogin = new RecLogin();
            recLogin.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLogin studentLogin = new StudentLogin();
            studentLogin.Show();
        }

        private void TeacherButton_Click(object sender, EventArgs e)
        {
            teacher teacher = new teacher();
            teacher.Show();
            this.Hide();
        }

        private void MangerButton_Click(object sender, EventArgs e)
        {
            mangerLogin mangerLogin = new mangerLogin();
            this.Hide();
            mangerLogin.Show();
        }
    }
}
