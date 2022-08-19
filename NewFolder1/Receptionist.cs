using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_management_system
{
    class Receptionist:user
    {
        static int c = 300;
        public Receptionist()
        {
            c = c + 1;
            this.Id = c;
        }
        public Receptionist(string UserName, int Password, string Name, int Year, int Month, int Day, string Nationalty, string Adress, string Gender) : base(UserName, Password, Name, Year, Month, Day, Nationalty, Adress, Gender)
        {
            c = c + 1;
            this.Id = c;
        }

        public string Check(string Name,int Id)
        {

            for (int i = 0; i < GlobalData.i; i++)
            {
                if(GlobalData.p[i].Name==Name && GlobalData.p[i].Id == Id)
                {

                    if (GlobalData.p[i] is Teatcher)

                        return "Teatcher " + GlobalData.p[i].Name + " is here";
                    if (GlobalData.p[i] is Student)

                        return "Student " + GlobalData.p[i].Name + " is here";

                    if (GlobalData.p[i] is Receptionist)

                        return"Receptionist "+GlobalData.p[i].Name+" is here";

                    
                }
            }

            return Name+" isn't here";

        }

        public override string Info()
        {
            return "Receptionist name : " + this.Name + " \nId : " + this.Id + "\ndate : " + this.Day + "/" + this.Month + "/" + this.Year + "\nGender : " + this.Gender + "\nNatiotanlty : " + this.Nationalty + "\nAdress : " + this.Adress;
        }

    }
}
