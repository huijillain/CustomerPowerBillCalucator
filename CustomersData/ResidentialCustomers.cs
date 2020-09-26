using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Residental Customers Class, connected with the Customers Class
namespace CustomersData
{
    public class ResidentialCustomers : Customers
    {
        public ResidentialCustomers(string accountNo,
            string customerName) : base(accountNo, customerName) { }

        public override decimal CalculateCharge(decimal kwh)
        {
            ChargeAmount = 6.0m + (0.052m * kwh);
            return ChargeAmount;
        }

        public override string GetName()
        {
            return "Residential";
        }
    }
}
