using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class Item
    {
        public int price;
        public int barcode;
        public string name;
        public int age;
        public double wheight;


        public void toString(int price,int barcode,string name,int weight)
        {
            Console.WriteLine(price);
            Console.WriteLine(barcode);
            Console.WriteLine(name);
            Console.WriteLine(wheight);
        }
    }
}
