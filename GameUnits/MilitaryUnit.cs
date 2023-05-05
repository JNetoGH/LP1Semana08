﻿namespace GameUnits
{
    public class MilitaryUnit : Unit 
    {
        
        private int movement;
        public int AttackPower { get; }
        public int XP { get; private set; }
        public override float Cost => AttackPower + XP;

        public override int Health 
        {
            get => base.Health + XP;
            set => base.Health = value;
        }

        public MilitaryUnit(int movement, int health, int attackPower) : base(movement, health)
        {
            AttackPower = attackPower;
            XP = 0;
        }

        public void Attack(Unit u)
        {
            XP++;
            u.Health -= AttackPower;
        }
        
        public override string ToString()
        {
            return $"{base.ToString()} AP={AttackPower} XP={XP}";
        }
        
    }
}