using System.Numerics;

namespace GameUnits
{
    public class SettlerUnit: Unit
    {
        private int movement;
        public int Health { get; set; }
        public override float Cost => 5;

        public SettlerUnit() : base(1,2) { }

        public void Settle(Vector2 position)
        {
            // code for settling the unit at the specified position
        }
    }
}