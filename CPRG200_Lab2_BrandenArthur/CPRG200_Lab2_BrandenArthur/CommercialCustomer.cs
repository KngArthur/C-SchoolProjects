using CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG200_Lab2_BrandenArthur
{

    public class CommercialCustomer : Customer
    {
        public double CommercialBase
        {
            get { return commercialBase; }
        }

        public double CommercialRate
        {
            get { return commercialRate; }
        }

        public double CommercialFlat
        {
            get { return commercialFlat; }
        }

        public int CommercialLimit
        {
            get { return commercialLimit; }
        }

        private double commercialBase;
        private double commercialRate;
        private double commercialFlat;
        private int commercialLimit;

        // constructor
        public CommercialCustomer(int an = 0, string cn = "unknown", string ct = "unknown", double c = 0) : base(an, cn, ct, c)
        {
            commercialBase = 60.00;
            commercialRate = 0.065;
            commercialFlat = 1000;
            commercialLimit = 1000;
        }

        public double commercialCalc(double useage)
        {
            if (useage > commercialFlat)
            {
                double usageCharge = commercialBase + ((useage - commercialLimit) * commercialRate);
                return usageCharge;
            }

            else
            {
                double usageCharge = commercialBase + (useage * commercialRate);
                return usageCharge;
            }
        }
    }
}

