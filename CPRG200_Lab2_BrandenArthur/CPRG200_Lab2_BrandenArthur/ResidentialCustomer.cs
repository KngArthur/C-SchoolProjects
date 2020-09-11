using CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG200_Lab2_BrandenArthur
{
    public class ResidentialCustomer : Customer
    {
        public double ResidentialBase
        {
            get { return residentialBase; }
        }

        public double ResidentialRate
        {
            get { return residentialRate; }
        }

        private double residentialBase;
        private double residentialRate;

        // constructor
        public ResidentialCustomer(int an = 0, string cn = "unknown", string ct = "unknown", double c = 0) : base(an, cn, ct, c)
        {
            residentialBase = 6.00;
            residentialRate = 0.052;
        }

        public double residentialCalc(double useage)
        {
            double usageCharge = residentialBase + (residentialRate * useage);
            return usageCharge;
        }
    }

}
