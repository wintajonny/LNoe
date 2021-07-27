using System;
using System.Transactions;

namespace AmbientTransactions
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TransactionScope scope = new(TransactionScopeOption.RequiresNew))
            {
                if (Transaction.Current is null) throw new InvalidOperationException();

                Transaction.Current.TransactionCompleted += (sender, e) =>
                    {
                        ShowTxInfo("completed", e.Transaction?.TransactionInformation);
                    };

                ShowTxInfo("created", Transaction.Current?.TransactionInformation);

                InnerMethod();
                scope.Complete();
            }  // Dispose  / commit/rollback beim root scope
        }

        static void InnerMethod()
        {
            using TransactionScope scope = new(TransactionScopeOption.Required);
            ShowTxInfo("inner method", Transaction.Current?.TransactionInformation);

            scope.Complete(); // happy bit set
        }

        static void ShowTxInfo(string title, TransactionInformation? txInfo)
        {
            if (txInfo is null) return;

            Console.WriteLine(title);
            Console.WriteLine($"creation time: {txInfo.CreationTime}");
            Console.WriteLine($"tx id {txInfo.LocalIdentifier}");
            Console.WriteLine($"dis tx id {txInfo.DistributedIdentifier}");
            Console.WriteLine($"status {txInfo.Status}");
            Console.WriteLine();
        }
    }
}
