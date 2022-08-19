using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_management_system
{
      class Room
    {   public string ClassName;
        public Student students;
        public Student students2;
        public Student students3;
        public Teatcher teatchers;
        public Room()
        {

        }
        public Room(Teatcher teatchers,string ClassName ,Student students, Student students2, Student students3 )
        {
            this.ClassName = ClassName;
            this.students = students;
            this.teatchers = teatchers;
            this.students2 = students2;
            this.students3 = students3;

           
        }

        public string ClassData()
        {
            return " Class name is : " + this.ClassName + "\nStdunent 1 is\n" + this.students.Info() + "\nStdunent 2 is\n" + this.students2.Info() + "\nStdunent 3 is\n" + this.students3.Info() + "\n The teatcher of this calass is \n" + this.teatchers.Info();
        }
    }
}
