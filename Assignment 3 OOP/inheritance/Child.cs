﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_OOP.inheritance
{
    public class Child :Parent
    {
        //public int X { get; set; }
        //public int Y { get; set; }
        public int Z { get; set; }


        public Child(int x, int y, int z): base (x,y)
        {
            //X = x;
            //Y = y;
            Z = z;
        }

        public new int ProductOfNumbers()
        {
            return X * Y* Z ;
        }
        public override string ToString()
        {
            return $"X={X}, Y={Y} Z={Z}";
        }

    }    
}