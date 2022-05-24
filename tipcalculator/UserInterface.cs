using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tipcalculator
{
    public class UserInterface
    {
        TipRepo _tipRepo = new TipRepo();

        public void Start()
        {
            AskUserForTotalBill();

            decimal totalBill = Convert.ToDecimal(Console.ReadLine());

            decimal totalBillWithTipIncluded = _tipRepo.CalculateTip(totalBill);

            Console.WriteLine("Your total bill with a 15% tip is " + totalBillWithTipIncluded + "!!!!");
            Console.ReadKey();
        
        }

        private void AskUserForTotalBill()
        {
            Console.Write("What was your total bill? : $");
        } 


    }
}