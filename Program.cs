using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Teatcher teatcher = new Teatcher("merna", 123, "merna eid", 1999, 9, 2, "Egyptian", "sidi bishr", "female");

            Student student = new Student("Mohamad", 123, "Mohamad Ashraf", 2000, 10, 18, "Egyptian", "semuha", "male");

            Student student1 = new Student("youssif", 123, "youssif Ashraf", 2000, 10, 18, "Egyptian", "semuha", "male");

            Student student2 = new Student("ali", 123, "ali", 2014, 10, 14, "Egyptian", "semuha", "male");

            Receptionist receptionist = new Receptionist("lara", 123, "lara", 2000, 10, 18, "uma", "ys", "male");

            GlobalData.AddReceptionist(receptionist);

            GlobalData.AddStudent(student);

            GlobalData.AddStudent(student1);

            GlobalData.AddStudent(student2);

             GlobalData.AddTeatcher(teatcher);

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());


            

        }
    }
}
