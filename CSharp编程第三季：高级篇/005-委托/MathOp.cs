﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_委托
{
    internal class MathOp
    {
        public static double MultiplyByTwo(double value)
        {
            return value * 2;
        }

        public static double Square(double value)
        {
            return value * value;
        }
    }
}