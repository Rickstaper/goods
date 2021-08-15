using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class Interface
    {
        public static void CreateThings (out IThing[] things)
        {
            things = new Thing[11]
            {
                new Thing(Option.TotalCost, 1),
                new Thing(Option.TotalCost, 24, 4),
                new Thing(Option.DiscountCost, 5, 10, 34.12),
                new Thing(Option.BonusCost, 25, 14.0),
                new Thing(Option.TransportChargeCost, 20, 25, 10.0),
                new Thing(Option.BonusCost, 15, 20),
                new Thing(Option.TotalCost, 11),
                new Thing(Option.DiscountCost, 4, 10, 100),
                new Thing(Option.TransportChargeCost, 4, 10),
                new Thing(Option.DiscountCost, 10),
                new Thing(Option.DiscountCost, 23, 15, 34.15)
            };
        }

        public static void DaysSort(ref IThing[] things)
        {
            for (int i = 0; i < things.Length; i++)
            {
                for (int j = 1; j < things.Length - i; j++)
                {
                    if (things[j - 1].Day > things[j].Day)
                    {
                        IThing temporary = things[j - 1];
                        things[j - 1] = things[j];
                        things[j] = temporary;
                    }
                }
            }
        }

        public static void OptionSort(ref IThing[] things)
        {
            IThing temporary;
            
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

        public static void Show(IThing[] things)
        {
            Console.WriteLine ("Number\tOption\t\t\t\tDay\t\tCount\t\tTotal Cost\tResulting cost");
            for (int i = 0; i < things.Length; i++)
            {
                Console.WriteLine ("{0, 3}\t{1, 8}\t\t{2, 10}\t{3, 11}\t{4, 12}\t{5, 14:0.00}", i + 1, things[i].GetOption (), things[i].Day, things[i].Count, things[i].TotalCost, things[i].ResultingCost);
            }
        }

        public static void IsTenth(IThing[] things)
        {
            foreach (IThing thing in things)
            {
                if (thing.Day == 1)
                {
                    Console.WriteLine ($"\nBuy was 10th {((Thing)thing).date.Month.ToString ()}, {((Thing)thing).date.Year.ToString ()}.");
                    break;
                    ;
                }
                else
                    Console.WriteLine ($"\nBuy wasn't 10th {((Thing)thing).date.Month.ToString ()}, {((Thing)thing).date.Year.ToString ()}.");
            }
        }
    }
}
