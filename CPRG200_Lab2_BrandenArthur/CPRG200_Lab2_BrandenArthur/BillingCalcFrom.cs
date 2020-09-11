using CPRG200_Lab2_BrandenArthur;
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
            int accountNo;
            string custName;
            string custType = "";
            double useage;
            double peakUseage = 0;
            double offPeakUseage = 0;

            useage = Convert.ToDouble(txbUseage.Text);
            accountNo = Convert.ToInt32(txbAccountNum.Text);
            custName = txbCustomerName.Text;

            {
                // calculate based on selected rate type
                if (rdbResidential.Checked == true && standardVal()
                   )
                {
                    ResidentialCustomer rcust = new ResidentialCustomer(accountNo, custName);
                    rcust.Charge = rcust.residentialCalc(useage);
                    txbCost.Text = rcust.Charge.ToString("c");
                    custType = "R";
                }
                else if (rdbCommercial.Checked == true && standardVal()
                        )
                {
                    CommercialCustomer ccust = new CommercialCustomer(accountNo, custName);
                    ccust.Charge = ccust.commercialCalc(useage);
                    txbCost.Text = ccust.Charge.ToString("c");
                }

                else if (rdbIndustrial.Checked == true && industrialVal()
                        )
                {
                    IndustrialCustomer icust = new IndustrialCustomer (accountNo, custName, custType);
                    icust.Charge = icust.industrialCalc(peakUseage, offPeakUseage);
                    txbCost.Text = icust.Charge.ToString("c");
                }
            }
        }

        public void rdbResidential_CheckedChanged(object sender, EventArgs e)
        {
            grbRegular.Visible = true;
            grbIndustrial.Visible = false;
        }

        public void rdbCommercial_CheckedChanged(object sender, EventArgs e)
        {
            grbRegular.Visible = true;
            grbIndustrial.Visible = false;
        }

        public void rdbIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            grbIndustrial.Visible = true;
            grbRegular.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int accountNo;
            string custName;
            double charge = 0;

           string custType = "";


            Customer newCust;

            if (Validator.IsPresent(txbAccountNum, "Account Number") &&
                Validator.IsPresent(txbCustomerName, "Customer Name")
               )
            {
                // input data
                accountNo = Convert.ToInt32(txbAccountNum.Text);
                custName = txbCustomerName.Text;

                // create product, add to list
                newCust = new Customer(accountNo, custName, custType, charge);
                customers.Add(newCust);
                DisplayCustomers();

                // clear saved input
                ClearForm();
            }
        }

        private void DisplayCustomers()
        {
            lstCustomers.Items.Clear();
            foreach (Customer c in customers)
                lstCustomers.Items.Add(c);
            lblCustTotal.Text = customers.Count.ToString();
            //lblResCharges.Text = 

        }

        /*private double CalculateResTotalCharges()
        {

        }

        private double CalculateComTotalCharges()
        {

        }

        private double CalculateIndTotalCharges()
        {

        }*/

        private double CalculateTotalCharges()
        {
            double total = 0;
            foreach (Customer c in customers)
                total += c.ChargeValue();
            return total;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
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

        public bool standardVal()
        {
            return Validator.IsPresent(txbUseage, "Useage") &&
                   Validator.IsNonNegativeDouble(txbUseage, "Useage");
        }

        public bool industrialVal()
        {
            return Validator.IsPresent(txbIPeak, "Peak Useage") &&
                   Validator.IsPresent(txbINonPeak, "Non-Peak Useage") &&
                   Validator.IsNonNegativeDouble(txbIPeak, "Peak Useage") &&
                   Validator.IsNonNegativeDouble(txbINonPeak, "Non-Peak Useage");
        }

        private void ClearForm()
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
    }
}
