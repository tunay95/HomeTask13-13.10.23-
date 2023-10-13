﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask13_13._10._23_
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private int _avgPoint;



        public int AvgPoint
        {
            get 
            {
                return _avgPoint;
            }
            set
            {
                if (value > 0 && value <= 100)
                { 
                    _avgPoint = value; 
                }
            }
        }
    }
}   

