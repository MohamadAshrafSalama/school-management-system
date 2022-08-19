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
    public partial class student__check_their_names : Form
    {
        public student__check_their_names()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void student__check_their_names_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GlobalData.j; i++)
            {
                if (this.textBox1.Text==GlobalData.students[i].Name && Convert.ToInt32(this.textBox2.Text) == GlobalData.students[i].Id)
                {
                    GlobalData.CurrntStuden = i;
                    assigment_with_marks assigment_With_Marks = new assigment_with_marks();
                    assigment_With_Marks.Show();
                    this.Hide();
                    break;
                    

                }
                else
                {
                    MessageBox.Show("Not here");
                }
            }
        }
    }
}
