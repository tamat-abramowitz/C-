using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using part3;
namespace part1
{
   public class Program
    {
        static void Main(string[] args)
        {

            teacher[] t = new teacher[3];
            t[0] = new teacher("sara levi", "java", 12000);
            t[1] = new teacher("dina kahan", "c++", 10500);
            t[2] = new teacher("shani lev", "server", 5000);

           

            var s2 = from item in t
                     where item.salary>10000
                     select item;


        }

    }
}
