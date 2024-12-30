using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accspecifiers
{
    public class Company
    {
        private int cid;
        private string cname;
        public Company(int id, string name)
        {
            this.cid = id;
            this.cname = name;
        }
        public void displayCompanyDetails()
        {
            Console.WriteLine("Company Registration Number:" + this.cid);
        }
    }

}

