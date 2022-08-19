using System;
using System.Collections.Generic;
using System.Text;

namespace school_management_system
{
    static  class GlobalData

    {
        public static string[] UserName = new string[10];
        public static int[] Password = new int[10];
        public static int i = 0;
        public static Student[] students = new Student[10];
        public static int j = 0;
        public static Teatcher[] teatchers = new Teatcher[10];
        public static int TeatcherCounter = 0;
        public static Receptionist[] receptionists = new Receptionist[10];
        public static int ReceptionistsCounter = 0;
        public static Room[] room = new Room[10];
        public static int RoomCounter = 0;
        public static int CurrntStuden;
        public static int CurrntTeacher;
        public static int CurrntReceptionist;
        public static user[] p = new user[10];
        public static Manger manger = new Manger("manger", 123, "lary", 1, 1, 1, "qwer", "qwer", "qe");
        

        
        


        public static void data(user user)
        {
            p[GlobalData.i] = user;
            i = i + 1;
        }
      public static void AddStudent(Student student)
        {
            GlobalData.students[j] = student;
            j = j + 1;
            GlobalData.data(student);
        }
        public static void AddTeatcher(Teatcher teatcher)
        {
            GlobalData.teatchers[TeatcherCounter] = teatcher;
            TeatcherCounter = TeatcherCounter + 1;
            GlobalData.data(teatcher);
        }
        public static void AddReceptionist(Receptionist receptionist)
        {
            GlobalData.receptionists[ReceptionistsCounter] = receptionist;
            ReceptionistsCounter = ReceptionistsCounter + 1;
            GlobalData.data(receptionist);
        }
        public static void AddRoom(Room room)
        {
            GlobalData.room[RoomCounter] = room;
            RoomCounter = RoomCounter + 1;
        }
        public static int LoginStudent(string UserName,int Password)
        {
            for (int i = 0; i < GlobalData.j; i++)
            {
                if(GlobalData.students[i].UserName == UserName && GlobalData.students[i].Password == Password)
                {
                    
                    return i;
                }
            }
            
            return 100;
        }
        public static int LoginTeatcher(string UserName, int Password)
        {
            for (int i = 0; i < GlobalData.TeatcherCounter; i++)
            {
                if(GlobalData.teatchers[i].UserName==UserName && GlobalData.teatchers[i].Password == Password)
                {
                    
                    return i;
                }
                
            }
            
            return 100;
        }
        public static int LoginReceptionist(string UserName, int Password)
        {
            for (int i = 0; i < GlobalData.ReceptionistsCounter; i++)
            {
                if (GlobalData.receptionists[i].UserName == UserName && GlobalData.receptionists[i].Password == Password)
                {

                    return i;
                }
            }
            
            return 100;
        }
    };

}
