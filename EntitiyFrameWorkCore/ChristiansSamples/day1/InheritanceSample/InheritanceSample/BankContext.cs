using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payment>()
                .HasDiscriminator<string>  ("PaymentType")
                .HasValue<CreditcardPayment>("Credit")
                .HasValue<CashPayment>("Cash");

            CreditcardPayment payment1 = new() { Amount = 100.40, CreditcardNumber = "738743", PaymentId = 1, Name="Gustav" };
            CashPayment payment2 = new() { Amount = 0.5, Name = "Donald", PaymentId = 2 };
            CashPayment payment3 = new() { Amount = 87456, Name = "Dagobert", PaymentId = 3 };
            modelBuilder.Entity<CashPayment>().HasData(payment2, payment3);
            modelBuilder.Entity<CreditcardPayment>().HasData(payment1);
        }

        public DbSet<Payment> Payments => Set<Payment>(); 
        //public DbSet<CreditcardPayment> CreditcardPayments => Set<CreditcardPayment>();
        //public DbSet<CashPayment> CashPayments => Set<CashPayment>();

    }
}
