using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part3
{
    public class teacher
    {
         public string name { get; set; }
       public string  subject { get; set; }
       public int salary { get; set; }

        public teacher(string name, string subject, int salary)
        {
            this.name = name;
            this.subject = subject;
            this.salary = salary;
        }
    }
}
