using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkChallenge
{
    public class SavingAccount
    {
        public Guid SavingAccountId { get; set; }
        public Double Amount { get; set; }
        public Double Rate { get; set; }
        public bool IsRatebyMonth { get; set; }
    }
}
