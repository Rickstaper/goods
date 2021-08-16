using System;

namespace Goods
{
    class Program
    {
        static void Main (string[] args)
        {
            IThing[] things;
            Interface.CreateThings (out things);

            Console.WriteLine ("First presentation of things:\n");
            Interface.Show (things);

            Array.Sort (things);

            Console.WriteLine ("\nSecond presentation of things after days sort:\n");
            Interface.Show (things);

            Interface.IsTenth (things);

            Interface.OptionSort (ref things);

            Console.WriteLine ("\nThird presentation of things after option sort:\n");
            Interface.Show (things);
        }
    }
}
