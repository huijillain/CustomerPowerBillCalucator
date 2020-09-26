using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Industrial Customers Class, from Customers Class
namespace CustomersData
{
    public class IndustrialCustomers : Customers
    {
        public IndustrialCustomers(string accountNo, string customerName)
            : base(accountNo, customerName)
        {
        }

        public override decimal CalculateCharge(decimal peak, decimal offPeak)
        {
            decimal newKWH = (peak - 1000m) <= 0 ? 0 : peak - 1000m;
            decimal newPeak = 76.0m + (newKWH * 0.06m);
            newKWH = (offPeak - 1000m) <= 0 ? 0 : offPeak - 1000m;
            decimal newoffPeak = 40.0m + (newKWH * 0.028m);
            ChargeAmount = newPeak + newoffPeak;
            return ChargeAmount;
        }

        public override string GetName()
        {
            return "Industrial";
        }
    }
}
