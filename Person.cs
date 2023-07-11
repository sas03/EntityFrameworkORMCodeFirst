using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkChallenge
{
    public class Person
    {
        public Guid PersonId { get; set; }
        public String Name { get; set; }
        public ICollection<SavingAccount> SavingAccounts { get; set; }
    }
}
