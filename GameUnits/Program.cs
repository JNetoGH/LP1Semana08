using System;
using System.Numerics;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" ");
            SettlerUnit settler = new SettlerUnit();
            settler.Move(new Vector2(2f, 3f));
            Console.WriteLine($"SettlerUnit Health: {settler.Health}");
            Console.WriteLine($"SettlerUnit Cost: {settler.Cost}");
            
            Console.WriteLine(" ");
            MilitaryUnit military = new MilitaryUnit(2, 5, 10);
            military.Move(new Vector2(5f, 6f));
            Console.WriteLine($"MilitaryUnit Health: {military.Health}");
            Console.WriteLine($"MilitaryUnit Cost: {military.Cost}");
        }
    }
}