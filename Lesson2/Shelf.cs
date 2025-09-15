using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class Shelf
    {
        public int shelfNum;
        public int colNum;
        public int weightCapacity;
        public int current;
        public Item oneItem;

        public bool isFull()
        {
            double wheightNow= oneItem.wheight*current;
            if (wheightNow >= weightCapacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
