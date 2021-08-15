using System;

namespace Goods
{
    class Program
    {
        static void Main (string[] args)
        {
            IThing[] things;
            Interface.CreateThings (out things);

            Interface.Show (things);

            Interface.DaysSort (ref things);

            Interface.Show (things);

            Interface.IsTenth (things);

            Interface.OptionSort (ref things);

            Interface.Show (things);
        }
    }
}
