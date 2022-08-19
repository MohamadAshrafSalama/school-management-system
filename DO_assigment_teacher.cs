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
    public partial class DO_assigment_teacher : Form
    {
        public DO_assigment_teacher()
        {
            InitializeComponent();
        }

        private void DO_assigment_teacher_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            GlobalData.teatchers[GlobalData.CurrntTeacher].GiveAssignment(GlobalData.teatchers[GlobalData.CurrntTeacher].MakeAssignment(this.ans1.Text, this.ans2.Text));
            this.Hide();
        }
    }
}
