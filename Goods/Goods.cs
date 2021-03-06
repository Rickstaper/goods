using System;

namespace Goods
{
    class Deal : IDeal
    {
        public Option Selection { get; }

        public DateTime date = new DateTime (2001, 12, 1);

        public Deal (Option selection, int day, int count = 1, double other = 0)
        {
            date = new DateTime (date.Year, date.Month, day);

            Count = count;

            Selection = selection;

            switch(selection)
            {
                case Option.TotalCost:
                    ResultingCost = TotalCost;
                    break;
                case Option.DiscountCost:
                    ResultingCost = GetDiscountCost (other);
                    break;
                case Option.TransportChargeCost:
                    ResultingCost = GetTransportChargeCost (other);
                    break;
                case Option.BonusCost:
                    ResultingCost = GetBonusCost (other);
                    break;
                default:
                    throw new OptionException ("Selection has the other option.");
            }
        }

        public Deal (Option selection, int day, int count) : this (selection, day, count, 0) { }

        public Deal (Option selection, int day, double other) : this (selection, day, 1, other) { }

        public double TotalCost { get; set; } = 5;

        public double ResultingCost { get; set; } = 0;

        public int Day => date.Day;

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

        public string GetOption ()
        {
            switch(Selection)
            {
                case Option.TotalCost:
                    return "Total cost";
                case Option.DiscountCost:
                    return "Discount cost";
                case Option.TransportChargeCost:
                    return "TC cost";
                case Option.BonusCost:
                    return "Bonus cost";
            }

            return string.Empty;
        }

        public int CompareTo(object o)
        {
            IDeal thing = o as IDeal;

            if (thing != null)
                return this.Day.CompareTo (thing.Day);
            else
                throw new Exception ("Impossibility compare two objects.");
        }
    }
}