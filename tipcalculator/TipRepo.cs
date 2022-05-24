using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tipcalculator
{
    public class TipRepo
    {
        public decimal CalculateTip(decimal totalBill)
        {
           decimal totalWithTip;
           totalWithTip = totalBill* 1.15m;
            return totalWithTip;
        }
    }
}