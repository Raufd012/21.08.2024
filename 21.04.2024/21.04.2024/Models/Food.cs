﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._04._2024.Models
{
    public abstract class Food
    {
        private int _calorie;

        public int Calorie
        {
            get { return _calorie; }
            set { _calorie = value; }
        }
        public Food(int calorie)
        {
            Calorie = calorie;

        }

    }
}
