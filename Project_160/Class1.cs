using System;
using System.Collections.Generic;
using System.Text;

namespace Project160
{
    public class Parameters
    {
        //public int AddNumber(int x)
        //{
        //    return x;
        //}
        public int AddNumber(int x, int y = 10) //optional b.c default number
        {
            return x + y; //if one number given, will apply value of 10 to y
        }


    }
}
