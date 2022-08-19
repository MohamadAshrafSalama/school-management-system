using System;
using System.Collections.Generic;
using System.Text;

namespace school_management_system
{
    class Assignment
    {
        public string Done;
        public string q1;
        public string q2;
        public string q1Ans;
        public string q2Ans;

        public Assignment()
        {

        }
        public Assignment(string q1,string q2)
        {
            this.q1 = q1;
            this.q2 = q2;
        }

        public Assignment(string q1Ans,string q2Ans,string Done)
        {
            this.q1Ans = q1Ans;
            this.q2Ans = q2Ans;
            this.Done = Done;
        }
    }
}
