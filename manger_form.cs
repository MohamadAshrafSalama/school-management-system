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
    public partial class manger_form : Form
    {
        public manger_form()
        {
            InitializeComponent();
        }

        private void ShowAssignment_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GlobalData.manger.AllData());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Show_Class show_Class = new Show_Class();
            show_Class.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            make_class_mangercontrol make_Class_Mangercontrol = new make_class_mangercontrol();
            make_Class_Mangercontrol.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home  homee= new Home();
            this.Hide();
            homee.Show();
        }
    }
}
