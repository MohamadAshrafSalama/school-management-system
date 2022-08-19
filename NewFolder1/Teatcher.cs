using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_management_system
{
    class Teatcher:user
    {
        static int c = 200;
        public Teatcher()
        {
            c = c + 1;
            this.Id = c;
        }
        public Teatcher(string UserName, int Password, string Name, int Year, int Month, int Day, string Nationalty, string Adress, string Gender) : base(UserName, Password, Name, Year, Month, Day, Nationalty, Adress, Gender)
        {
            c = c + 1;
            this.Id = c;
        }
        public Assignment MakeAssignment(string q1,string q2)
        {
            Assignment assignment = new Assignment(q1,q2);
            return assignment;
            
        }
        public void GiveAssignment(Assignment assignment)
        {
            for (int i = 0; i < GlobalData.j; i++)
            {
                GlobalData.students[i].assignment = assignment;
            }
        }
        public string CheckAssignment(Student student)
        {

            return "q1 ans is : " + student.assignment.q1Ans + "\n q2 ans is : " + student.assignment.q2Ans;
                
            
        }
        public void MarkAssignment(int Mark,int i)
        {

            GlobalData.students[i].Mark = Mark;
        }

        public override string Info()
        {
            return "Teatcher name : " + this.Name + " \nId: " + this.Id + "\ndate: " + this.Day + " / " + this.Month + " / " + this.Year + "\nGender: " + this.Gender + "\nNatiotanlty: " + this.Nationalty + "\nAdress: " + this.Adress;
        }
    }   
}
