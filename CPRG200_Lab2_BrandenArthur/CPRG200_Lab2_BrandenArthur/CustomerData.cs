using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class Customer
    {
        private int accountNo;
        private string custName;
        private string custType;
        private double charge;

        public int AccountNo { get; set; }

        public string CustName { get; set; }

        public string CustType { get; set; }

        public double Charge { get; set; }



        public Customer(int an = 0, string cn = "unknown", string ct = "unknown", double c = 0)
        {
            AccountNo = an;
            CustName = cn;
            CustType = ct;
            Charge = c;
        }

        public override string ToString()
        {
            return AccountNo.ToString() + ": " + CustName + "," + CustType + "," + Charge.ToString("c");
        }

        public string ToFileString()
        {
            return AccountNo.ToString() + ": " + CustName + "," + CustType + "," + Charge.ToString();
        }

    }
}
