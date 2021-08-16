using System;

namespace Goods
{
    class Interface
    {
        public static void CreateThings (out IDeal[] things)
        {
            things = new Deal[11]
            {
                new Deal(Option.TotalCost, 1),
                new Deal(Option.TotalCost, 24, 4),
                new Deal(Option.DiscountCost, 5, 10, 34.12),
                new Deal(Option.BonusCost, 25, 14.0),
                new Deal(Option.TransportChargeCost, 20, 25, 10.0),
                new Deal(Option.BonusCost, 15, 20),
                new Deal(Option.TotalCost, 11),
                new Deal(Option.DiscountCost, 4, 10, 100),
                new Deal(Option.TransportChargeCost, 4, 10),
                new Deal(Option.DiscountCost, 10),
                new Deal(Option.DiscountCost, 23, 15, 34.15)
            };
        }

        public static void OptionSort(ref IDeal[] things)
        {
            IDeal temporary;
            
            for(int i = 0; i < things.Length; i++)
            {
                for (int j = 1; j < things.Length - i; j++)
                {
                    if (things[j - 1].Selection > things[j].Selection)
                    {
                        temporary = things[j - 1];
                        things[j - 1] = things[j];
                        things[j] = temporary;
                    }
                }
            }
        }

        public static void Show(IDeal[] things)
        {
            Console.WriteLine ("Number\tOption\t\t\t\tDay\t\tCount\t\tTotal Cost\tResulting cost");
            for (int i = 0; i < things.Length; i++)
            {
                Console.WriteLine ("{0, 3}\t{1, 8}\t\t{2, 10}\t{3, 11}\t{4, 12}\t{5, 14:0.00}", i + 1, things[i].GetOption (), things[i].Day, things[i].Count, things[i].TotalCost, things[i].ResultingCost);
            }
        }

        public static void IsTenth(IDeal[] things)
        {
            foreach (IDeal thing in things)
            {
                if (thing.Day == 1)
                {
                    Console.WriteLine ($"\nBuy was 10th {((Deal)thing).date.Month.ToString ()}, {((Deal)thing).date.Year.ToString ()}.");
                    break;
                    ;
                }
                else
                    Console.WriteLine ($"\nBuy wasn't 10th {((Deal)thing).date.Month.ToString ()}, {((Deal)thing).date.Year.ToString ()}.");
            }
        }
    }
}
