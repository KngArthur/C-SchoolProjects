using CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG200_Lab2_BrandenArthur
{
    public class IndustrialCustomer : Customer
    {
        public double IndustrialPeakBase
        {
            get { return industrialPeakBase; }
        }

        public double IndustrialOffpeakBase
        {
            get { return industrialOffpeakBase; }
        }

        public double IndustrialPeakRate
        {
            get { return industrialPeakRate; }
        }

        public double IndustrialOffpeakRate
        {
            get { return industrialOffpeakRate; }
        }

        public double IndustrialFlat
        {
            get { return industrialFlat; }
        }

        public int IndustrialLimit
        {
            get { return industrialLimit; }
        }

        private double industrialPeakBase;
        private double industrialOffpeakBase;
        private double industrialPeakRate;
        private double industrialOffpeakRate;
        private double industrialFlat;
        private int industrialLimit;

        // constructor
        public IndustrialCustomer(int an = 0, string cn = "unknown", string ct = "unknown", double c = 0) : base(an, cn, ct, c)
        {
            industrialPeakBase = 76.00;
            industrialOffpeakBase = 40.00;
            industrialPeakRate = 0.065;
            industrialOffpeakRate = 0.028;
            industrialFlat = 1000;

            industrialLimit = 1000;
        }

        public double industrialCalc(double peakUseage, double offPeakUseage)
        {
            double usageCharge = (IndustrialOffpeakBase + ((offPeakUseage - industrialLimit) * industrialOffpeakRate))
                                 +
                                 (industrialPeakBase + ((peakUseage - industrialLimit) * industrialPeakRate));
            return usageCharge;
        }
    }
}
