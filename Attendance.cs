using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPsEmployeeWage
{
    public class Attendance
    {
        public void CheckAttendance(){
            Random rnd=new Random();
            if(rnd.Next(2)==0)
                Console.WriteLine("Present");
            else   
                Console.WriteLine("Absent");
        }
    }
}