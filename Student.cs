using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accspecifiers
{
    class Student
    {
        public int sid;
        public string name;
        public static string collegename ;
        public string cname = "Engineering";
        public const int semester=2;
        public Student(int s,string sname)
        {
           sid = s;
            this.name = sname;
        }
    }
}
