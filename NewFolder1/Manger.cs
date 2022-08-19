using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_management_system
{
    class Manger:user
    {
        public Manger()
        {

        }
        public Manger(string UserName, int Password, string Name, int Year, int Month, int Day, string Nationalty, string Adress, string Gender) : base(UserName, Password, Name, Year, Month, Day, Nationalty, Adress, Gender)
        {

        }
       
        public string AllData()
        {
            string x=" ";
            for (int i = 0; i < GlobalData.i; i++)
            {
                x = x + "-------------- \n" + GlobalData.p[i].Info() + "\n";
                
            }
            return x;
        }
        public void MakeClass(string ClassName,Student student,Student student2,Student student3,Teatcher teatcher)
        {
            Room room = new Room(teatcher,ClassName,student,student2,student3);

            GlobalData.AddRoom(room);
        }

        public string CheckClass(string ClassName)
        {
            for (int i = 0; i < GlobalData.RoomCounter; i++)
            {
                if (ClassName == GlobalData.room[i].ClassName)
                {
                    return GlobalData.room[i].ClassData();
                }
            }
             return "nop";
        }
        
    }
}
