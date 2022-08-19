using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_management_system
{
    class Student:user
    {
       public Assignment assignment= new Assignment();
        public int Mark;

        static int c = 100;
        public Student() {
            c = c+1;
            this.Id = c;
        }   
        public Student(string UserName, int Password, string Name,  int Year, int Month, int Day, string Nationalty, string Adress, string Gender  ):base(UserName,Password,Name,Year,Month,Day,Nationalty,Adress,Gender)
        {
            c = c + 1;
            this.Id = c;

            
        }
        public int ShowMarks()
        {
            return this.Mark;
        }
        public void DoAssignment(string Done,string q1Ans,string q2Ans)
        {
            this.assignment.Done = Done;
            this.assignment.q2Ans = q2Ans;
            this.assignment.q1Ans = q1Ans;
        }
        public string ShowAssignment()
        {
            return "q1 is : "+this.assignment.q1+"\nq2 is : "+this.assignment.q2;
        }
        public override string Info()
        {
            return "Studen name : " + this.Name + " \nId : " + this.Id + "\ndate : " + this.Day + "/" + this.Month + "/" + this.Year + "\nGender : " + this.Gender + "\nNatiotanlty : " + this.Nationalty + "\nAdress : " + this.Adress;
        }
    }
}
