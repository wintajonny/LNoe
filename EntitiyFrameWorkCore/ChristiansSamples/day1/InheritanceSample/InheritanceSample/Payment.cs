using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    public abstract class Payment
    {
        public int PaymentId { get; set; }
        public double Amount { get; set; }
        public string? Name { get; set; }
    }

    public class CashPayment : Payment
    {

    }

    public class CreditcardPayment : Payment
    {
        [StringLength(20)]
        public string? CreditcardNumber { get; set; }
    }
}
