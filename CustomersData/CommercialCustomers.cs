using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Commercial Customers Class, from Customers Class
namespace CustomersData
{
    public class CommercialCustomers : Customers
    {
        public CommercialCustomers(string accountNo,
           string customerName) : base(accountNo, customerName) { }

        public override decimal CalculateCharge(decimal kwh)
        {
            decimal newKWH = (kwh - 1000m) <= 0 ? 0 : kwh - 1000m;
            ChargeAmount = 60.0m + (newKWH * 0.045m);
            return ChargeAmount;
        }

        public override string GetName()
        {
            return "Commercial";
        }
    }
}
