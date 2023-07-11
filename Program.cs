using EntityFrameworkChallenge;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public class Program
{
    public static void InitDb()
    {
        using (var context = new SavingContext())
        {
            context.Database.EnsureDeleted();

            context.Database.EnsureCreated();

            List<SavingAccount> Accounts = new List<SavingAccount>
            {
                new SavingAccount() {Amount = 2000000, Rate = 0.05, IsRatebyMonth = true },
                new SavingAccount() {Amount = 250000, Rate = 0.15, IsRatebyMonth = false },
                new SavingAccount() {Amount = 10000000, Rate = 0.02, IsRatebyMonth = false },
            };

            Person person = new Person() { Name = "Mr Person", SavingAccounts = Accounts };

            context.Add(person);
            context.SaveChanges();
        }
    }
    public static void Main(string[] args)
    {
        InitDb();
        using (var context = new SavingContext()) {

            IQueryable<Person> query = context.Person.Where(p => p.Name == "Mr Person");
            
            query = query.Include(p => p.SavingAccounts);
            
            Person person = query.FirstOrDefault();

            Console.WriteLine(person.Name);

            foreach(var account in person.SavingAccounts)
            {
                Console.WriteLine("Account number: " + account.SavingAccountId);
                Console.WriteLine("Account rate: " + account.Rate + " by " + (account.IsRatebyMonth ? "month" : "year"));
                Console.WriteLine("Initial amount: " + account.Amount);
                Console.WriteLine("Current amount: " + SavingCalculator.Calcul(account));
            }
        }
    }
}