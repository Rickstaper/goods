﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    interface IThing
    {
        double TotalCost { get; set; }

        double ResultingCost { get; set; }

        int Count { get; set; }

        double GetDiscountCost (double perCent);

        double GetTransportChargeCost (double transportCharges);

        double GetBonusCost (double bonusPrice);
    }
}