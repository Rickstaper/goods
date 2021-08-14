using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    class Thing : IThing
    {
        public Thing (int selection, int day, int count = 1, double other = 0)
        {
            date = new DateTime (date.Year, date.Month, day);

            Count = count;

            switch(selection)
            {
                case 1:
                    ResultingCost = TotalCost;
                    break;
                case 2:
                    ResultingCost = GetDiscountCost (other);
                    break;
                case 3:
                    ResultingCost = GetBonusCost (other);
                    break;
                default:
                    throw new ArgumentException ();
            }
        }

        public Thing (int selection, int day, int count) : this (selection, day, count, 0) { }

        public Thing (int selection, int day, double other) : this (selection, day, 1, other) { }

        public double TotalCost { get; set; } = 5;

        public double ResultingCost { get; set; } = 0;

        DateTime date = new DateTime(2001, 12, 1);

        public int Count { get; set; } = 0;

        public double GetDiscountCost(double percent)
        {
            return TotalCost * Count * (1 - percent / 100);
        }

        public double GetTransportChargeCost(double transportCharges)
        {
            return TotalCost * Count - transportCharges;
        }

        public double GetBonusCost(double bonusCost)
        {
            return TotalCost * Count - bonusCost;
        }
    }
}