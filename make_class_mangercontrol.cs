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
    public partial class make_class_mangercontrol : Form
    {
        public make_class_mangercontrol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y, z, t ;
            x = y = z = t = 0;
            for (int i = 0; i < GlobalData.j; i++)
            {
                if(this.name1.Text==GlobalData.students[i].Name && Convert.ToInt32(this.id1.Text)== GlobalData.students[i].Id)
                {
                    x = i;
                }
            }
            for (int i = 0; i < GlobalData.j; i++)
            {
                if (this.name2.Text == GlobalData.students[i].Name && Convert.ToInt32(this.id2.Text) == GlobalData.students[i].Id)
                {
                    y = i;
                }
            }
            for (int i = 0; i < GlobalData.j; i++)
            {
                if (this.name3.Text == GlobalData.students[i].Name && Convert.ToInt32(this.id3.Text) == GlobalData.students[i].Id)
                {
                    z = i;
                }
            }
            for (int i = 0; i < GlobalData.TeatcherCounter; i++)
            {
                if (this.name4.Text == GlobalData.teatchers[i].Name && Convert.ToInt32(this.id4.Text) == GlobalData.teatchers[i].Id)
                {
                    t = i;
                }
            }
            GlobalData.manger.MakeClass(this.classname.Text, GlobalData.students[x], GlobalData.students[y], GlobalData.students[z], GlobalData.teatchers[t]);
            this.Hide();
        }
    }
}
