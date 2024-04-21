﻿

namespace _21._04._2024.Models
{
    internal class Wolf : Animal
    {
        private bool _isPrideLeader;
        private int _attackDamage;

        public bool IsPrideLeader
        {
            get { return _isPrideLeader; }
            set { _isPrideLeader = value; }
        }

        public int AttackDamage
        {
            get { return _attackDamage; }
            set { _attackDamage = value; }
        }


        public Wolf(int avglifetime, string breed, int healtpoint, Gender gender, bool isleader, int attackdamage) : base(avglifetime, breed, healtpoint, gender)
        {
            IsPrideLeader = isleader;
            AttackDamage = attackdamage;
        }

        public void Hunt<T>(T animal) where T : Animal
        {
            animal.HP -= AttackDamage;
            Console.WriteLine(HP);
        }

    }
}
