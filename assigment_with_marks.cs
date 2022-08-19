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
    public partial class assigment_with_marks : Form
    {
        public assigment_with_marks()
        {
            InitializeComponent();
        }

        private void assigment_with_marks_Load(object sender, EventArgs e)
        {
            this.q1.Text = "Question 1 : " + GlobalData.students[GlobalData.CurrntStuden].assignment.q1;
            this.q2.Text = "Question 2 : " + GlobalData.students[GlobalData.CurrntStuden].assignment.q2;
            this.q1ans.Text = "Question 1 Answer : " + GlobalData.students[GlobalData.CurrntStuden].assignment.q1Ans;
            this.q2ans.Text = "Question 2 Answer : " + GlobalData.students[GlobalData.CurrntStuden].assignment.q2Ans;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalData.teatchers[GlobalData.CurrntTeacher].MarkAssignment(Convert.ToInt32(this.grade.Text), GlobalData.CurrntStuden) ;
            this.Hide();
        }

        private void grade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
