using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    interface IDeal : IComparable
    {
        double TotalCost { get; set; }

        double ResultingCost { get; set; }

        int Count { get; set; }

        int Day { get; }

        Option Selection { get; }

        double GetDiscountCost (double perCent);

        double GetTransportChargeCost (double transportCharges);

        double GetBonusCost (double bonusPrice);

        string GetOption ();
    }
}