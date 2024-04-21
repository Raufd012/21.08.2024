using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._04._2024.Models
{
    internal class Meat : Food
    {
        private Type _type;

        public Type Typepr
        {
            get { return _type; }
            set { _type = value; }
        }
        public enum Type
        {
            chicken,
            beef,
            fish,
            baccon

        }

        public Meat(int calorie, Type type) : base(calorie)
        {
            Typepr = type;
        }
    }
}
