using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Customer Data Project, Customers Class
namespace CustomersData
{
    public abstract class Customers
    {
        public string AccountNo { get; private set; }
        public string CustomerName { get; private set; }
        public decimal ChargeAmount { get; protected set; }

        public Customers(string accountNo,
            string customerName)
        {
            AccountNo = accountNo;
            CustomerName = customerName;
        }

        public virtual decimal CalculateCharge(decimal kwh)
        {
            return 0;
        }
        public virtual decimal CalculateCharge(decimal peak, decimal offPeak)
        {
            return 0;
        }

        public override string ToString()
        {
            return $"AccountNo: {AccountNo}, CustomerName: {CustomerName}, ChargeAmount: {ChargeAmount}";
        }

        public abstract string GetName();
    }
}
