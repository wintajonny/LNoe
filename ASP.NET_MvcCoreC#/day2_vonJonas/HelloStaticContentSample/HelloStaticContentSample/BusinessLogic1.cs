using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloStaticContentSample
{
    public interface ICustomerDb
    {
        public double GetTurnoverForCustomer(int customerId, int lastDays);
    }
    public class CustomerDb : ICustomerDb
    {
        public double GetTurnoverForCustomer(int customerId, int lastDays)
        {
            // query DB...
            return 2000;
        }
    }
    public class BusinessLogic1
    {
        public BusinessLogic1(ICustomerDb customer)
        {
            CustomerDb = customer;
        }

        private readonly ICustomerDb CustomerDb;

        public double ComputePriceForCustomer(int customerId, double listPrice)
        {
            //Kundengruppe...
            //letzte Umsätze...
           // CustomerDB db = new CustomerDB(); //connection string
            double turnover = CustomerDb.GetTurnoverForCustomer(customerId, 100);
            return turnover > 1000 ? listPrice * 0.95 : listPrice;
        }

    }
}
