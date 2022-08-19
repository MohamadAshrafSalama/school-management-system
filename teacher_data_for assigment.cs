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
    public partial class teacher_data_for_assigment : Form
    {
        public teacher_data_for_assigment()
        {
            InitializeComponent();
        }

        private void teacher_data_for_assigment_Load(object sender, EventArgs e)
        {
            this.NameLabel.Text = "Teacher name : " + GlobalData.teatchers[GlobalData.CurrntTeacher].Name;
            this.nationaltylable.Text="Teacher Nationalty :"+GlobalData.teatchers[GlobalData.CurrntTeacher].Nationalty;
            this.IdLable.Text = "Teacher Id : " + GlobalData.teatchers[GlobalData.CurrntTeacher].Id;
            this.GenderLable.Text = "Teacher Gender : " + GlobalData.teatchers[GlobalData.CurrntTeacher].Gender;
            this.adress.Text = "Teacher Adress : " + GlobalData.teatchers[GlobalData.CurrntTeacher].Adress;
            this.date.Text = "Teacher Date of Birth : " + GlobalData.teatchers[GlobalData.CurrntTeacher].Day + " / " + GlobalData.teatchers[GlobalData.CurrntTeacher].Month + " / " + GlobalData.teatchers[GlobalData.CurrntTeacher].Year;


        }

        private void ShowAssignment_Click(object sender, EventArgs e)
        {
            DO_assigment_teacher teacher = new DO_assigment_teacher();
            teacher.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            student__check_their_names student__Check_Their_Names = new student__check_their_names();
            student__Check_Their_Names.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
