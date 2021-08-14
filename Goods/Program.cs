using System;

namespace Goods
{
    class Program
    {
        static void Main (string[] args)
        {
            IThing[] things = new IThing[10]
            {
                new Thing(1, 1),
                new Thing(1, 24, 4),
                new Thing(2, 5, 10, 34.12),
                new Thing(3, 25, 14.0),
                new Thing(1, 20, 25, 10.0),
                new Thing(2, 15, 20),
                new Thing(2, 11),
                new Thing(2, 4, 10, 100),
                new Thing(3, 4, 10),
                new Thing(2, 10)
            };

            foreach(IThing thing in things)
            {
                Console.WriteLine (thing.ResultingCost);
            }
        }
    }
}
