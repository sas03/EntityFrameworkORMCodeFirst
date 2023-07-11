using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkChallenge
{
    public class SavingCalculator
    {
        public static Double Calcul(SavingAccount account)
        {
            int nbIteration = 3;
            if (account.IsRatebyMonth)
                nbIteration = nbIteration * 12;

            double res = account.Amount;
            for(int i = 0; i < nbIteration; i++)
            {
                res = res * (1 + account.Rate);
            }
            return res;
        }
    }
}
