using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_management_system
{
    abstract class user
    {
        // static Random r = new Random();
        //public int Id = r.Next(100,200);
        public string Name;
        public int Id;
        public string UserName;
        public int Password;
        public int Year;
        public int Day;
        public int Month;
        public string Nationalty;
        public string Adress;
        public string Gender;
        public user(){}

        public user(string UserName,int Password,string Name,int Year,int Month,int Day,string Nationalty,string Adress,string Gender)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Name = Name;
            this.Year = Year;
            this.Day = Day;
            this.Month = Month;
            this.Adress = Adress;
            this.Gender = Gender;
            this.Nationalty = Nationalty;
        }


        public virtual string Info() 
        {
            return "null";
        }

       /*public virtual string LoginName()
        {
            return this.UserName;
        }
        public virtual int LoginPass()
        {
            return this.Password;
        }
    */

    }
}
