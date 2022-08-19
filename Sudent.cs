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
    public partial class Sudent : Form
    {
        public Sudent()
        {
            InitializeComponent();
        }

        private void Sudent_Load(object sender, EventArgs e)
        {
            this.NameLabel.Text = "Student name : "+GlobalData.students[GlobalData.CurrntStuden].Name;
            this.adress.Text= "Adress : " + GlobalData.students[GlobalData.CurrntStuden].Adress;
            this.GenderLable.Text = "Gender : " + GlobalData.students[GlobalData.CurrntStuden].Gender;
            this.IdLable.Text = "Id : " + GlobalData.students[GlobalData.CurrntStuden].Id;
            this.nationaltylable.Text = "Nationalty : " + GlobalData.students[GlobalData.CurrntStuden].Nationalty;
            this.date.Text = "Date : " + GlobalData.students[GlobalData.CurrntStuden].Day + " / " + GlobalData.students[GlobalData.CurrntStuden].Month + " / " + GlobalData.students[GlobalData.CurrntStuden].Year;
        }

        private void GenderLable_Click(object sender, EventArgs e)
        {

        }

        private void ShowAssignment_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GlobalData.students[GlobalData.CurrntStuden].ShowAssignment());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoAssignment doAssignment = new DoAssignment();
            doAssignment.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString( GlobalData.students[GlobalData.CurrntReceptionist].ShowMarks()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
