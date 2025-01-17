using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_OOP.inheritance
{
    public class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }
    

    public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int ProductOfNumbers()
        { 
            return X * Y; 
        }

        public override string ToString()
        {
            return $"X={X}, Y={Y}";
        }
    }
}
