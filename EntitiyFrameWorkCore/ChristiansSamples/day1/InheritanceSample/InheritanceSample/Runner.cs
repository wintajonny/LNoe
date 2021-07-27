using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    class Runner
    {
        private readonly BankContext _bankContext;

        public Runner(BankContext bankContext)
        {
            _bankContext = bankContext ?? throw new ArgumentNullException(nameof(bankContext));
        }

        public async Task CreateDatabaseAsync()
        {
            await _bankContext.Database.EnsureCreatedAsync();
        }

        public async Task QueryAsync()
        {
            var cashPayments = await _bankContext.Payments.OfType<CashPayment>().ToListAsync();

            foreach (var item in cashPayments)
            {
                Console.WriteLine($"{item.Name} {item.Amount}");
            }

            var entries = _bankContext.ChangeTracker.Entries<CashPayment>();
            foreach (var entry in entries)
            {
                var disc = entry.CurrentValues["PaymentType"];
            }
        }
    }
}
