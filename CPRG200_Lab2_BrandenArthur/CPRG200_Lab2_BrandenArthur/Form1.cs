using CustomerData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRG200_Lab1_BrandenArthur
    /*
     * this is an app that calculates energy useage cost
     * Author: Branden Arthur
     * Date: August 31, 2020
     */
{
    public partial class frmCustomers : Form
    {
        // create list of customers
        List<Customer> customers = new List<Customer>();

        // rate constant variables
        const double RESIDENTIAL_BASE           = 6.00;
        const double RESIDENTIAL_RATE           = 0.052;

        const double COMMERCIAL_BASE            = 60.00;
        const double COMMERCIAL_RATE            = 0.065;
        const double COMMERCIAL_FLAT            = 1000;

        const double INDUSTRIAL_PEAK_BASE       = 76.00;
        const double INDUSTRIAL_OFFPEAK_BASE    = 40.00;
        const double INDUSTRIAL_PEAK_RATE       = 0.065;
        const double INDUSTRIAL_OFFPEAK_RATE    = 0.028;
        const double INDUSTRIAL_FLAT            = 1000;

        const int COMMERCIAL_LIMIT              = 1000;
        const int INDUSTRIAL_LIMIT              = 1000;

        string selectedType = "R";

        public frmCustomers()
        {
            InitializeComponent();
            // set default visibility
            grbIndustrial.Visible = false;
            grbRegular.Visible = false;
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            try
            {
                customers = CustomerDataDB.ReadCustomers();
                DisplayCustomers();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error when loading data: " + ex.Message, ex.GetType().ToString());
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double usageCharge;
            // validate data
            {
                // calculate based on selected rate type
                if (rdbResidential.Checked == true && standardVal()
                   )
                {
                    double useage;

                    useage = Convert.ToDouble(txbUseage.Text);
                    usageCharge = residentialCalc(useage);

                }
                else if (rdbCommercial.Checked == true && standardVal()
                        )
                {
                    double useage;

                    useage = Convert.ToDouble(txbUseage.Text);

                    usageCharge = commercialCalc(useage);
                }

                else if (rdbIndustrial.Checked == true && industrialVal()
                        )
                {
                    double peakUseage;
                    double offPeakUseage;

                    peakUseage = Convert.ToDouble(txbIPeak.Text);
                    offPeakUseage = Convert.ToDouble(txbINonPeak.Text);
                    usageCharge = industrialCalc(peakUseage, offPeakUseage);
                }
            }
        }

        public void rdbResidential_CheckedChanged(object sender, EventArgs e)
        {
            grbRegular.Visible = true;
            grbIndustrial.Visible = false;

            selectedType = "R";
        }

        public void rdbCommercial_CheckedChanged(object sender, EventArgs e)
        {
            grbRegular.Visible = true;
            grbIndustrial.Visible = false;

            selectedType = "C";
        }

        public void rdbIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            grbIndustrial.Visible = true;
            grbRegular.Visible = false;

            selectedType = "I";

        }

        private void txbUseage_TextChanged(object sender, EventArgs e)
        {

        }
        private void txbAccountNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void grbRegular_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int accountNo;
            string custName;
            string custType;
            double charge;
            
            Customer newCust;

            if (Validator.IsPresent(txbAccountNum, "Account Number") &&
                Validator.IsPresent(txbCustomerName, "Customer Name")
               )
            {
                // input data
                accountNo = Convert.ToInt32(txbAccountNum.Text);
                custName = txbCustomerName.Text;
                charge = Convert.ToDouble(usageCharge);
                custType = "";
                
                // create product, add to list
                newCust = new Customer(accountNo, custName, custType, charge);
                customers.Add(newCust);
                DisplayCustomers();
            }
        }

        private void DisplayCustomers()
        {
            lstCustomers.Items.Clear();
            foreach (Customer c in customers)
                lstCustomers.Items.Add(c);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbAccountNum.Text = "";
            txbCustomerName.Text = "";
            if (rdbIndustrial.Checked == true)
            {
                txbIPeak.Text = "";
                txbINonPeak.Text = "";
            }

            else
            {
                txbUseage.Text = "";
            }
            txbCost.Text = "";
            rdbResidential.Checked = false;
            rdbCommercial.Checked = false;
            rdbIndustrial.Checked = false;
            grbIndustrial.Visible = false;
            grbRegular.Visible = false;
            txbAccountNum.Focus();
        }

        private void frmCustomers_formClosing(object sender, FormClosedEventArgs e)
        {
            try
            {
                CustomerDataDB.SaveCustomers(customers);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problem when saving data: " + ex.Message, ex.GetType().ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public double industrialCalc(double peakUseage, double offPeakUseage)
        {
            double usageCharge = (INDUSTRIAL_OFFPEAK_BASE + ((offPeakUseage - INDUSTRIAL_LIMIT) * INDUSTRIAL_OFFPEAK_RATE))
                        +
                            (INDUSTRIAL_PEAK_BASE + ((peakUseage - INDUSTRIAL_LIMIT) * INDUSTRIAL_PEAK_RATE));
            txbCost.Text = usageCharge.ToString("c");
            return usageCharge;
        }

        public double commercialCalc(double useage)
        {
            double usageCharge;
            if (useage > COMMERCIAL_FLAT)
            {
                usageCharge = COMMERCIAL_BASE + ((useage - COMMERCIAL_LIMIT) * COMMERCIAL_RATE);
                txbCost.Text = usageCharge.ToString("c");
            }

            else
            {
                usageCharge = COMMERCIAL_BASE + (useage * COMMERCIAL_RATE);
                txbCost.Text = usageCharge.ToString("c");
            }

            return usageCharge;
        }

        public double residentialCalc(double useage)
        {
            double usageCharge = RESIDENTIAL_BASE + (RESIDENTIAL_RATE * useage);
            txbCost.Text = usageCharge.ToString("c");
            return usageCharge;
        }

        private bool standardVal()
        {
            return Validator.IsPresent(txbUseage, "Useage") &&
                   Validator.IsNonNegativeDouble(txbUseage, "Useage");
        }

        private bool industrialVal()
        {
            return Validator.IsPresent(txbIPeak, "Peak Useage") &&
                   Validator.IsPresent(txbINonPeak, "Non-Peak Useage") &&
                   Validator.IsNonNegativeDouble(txbIPeak, "Peak Useage") &&
                   Validator.IsNonNegativeDouble(txbINonPeak, "Non-Peak Useage");
        }
    }
}
