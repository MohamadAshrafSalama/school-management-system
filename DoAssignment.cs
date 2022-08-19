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
    public partial class DoAssignment : Form
    {
        public DoAssignment()
        {
            InitializeComponent();
        }

        private void DoAssignment_Load(object sender, EventArgs e)
        {
            this.label1.Text = GlobalData.students[GlobalData.CurrntStuden].ShowAssignment();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalData.students[GlobalData.CurrntStuden].DoAssignment("true", this.ans1.Text, this.ans2.Text);

            this.Hide();
        }
    }
}
