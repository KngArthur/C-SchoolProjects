using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRG200_Lab1_BrandenArthur
{
    // collection of validation methods
    public static class Validator
    {
        /// <summary>
        /// check if text box contains anything
        /// </summary>
        /// <param name="tb">text box to validate</param>
        /// <param name="name">name for error message</param>
        /// <returns>true if text box not empty and false if empty</returns>
        public static bool IsPresent(TextBox tb, String name)
        {
            bool isValid = true;
            if (tb.Text == "")
            {
                isValid = false;
                MessageBox.Show(name + " is required", "Input error");
                tb.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// check if text box contains non-negative int value
        /// </summary>
        /// <param name="tb">text box to validate</param>
        /// <param name="name">true is balid and false if not</param>
        public static bool IsNonNegativeInterger(TextBox tb, string name)
        {
            bool isValid = true;
            int val;
            if (!Int32.TryParse(tb.Text, out val)) // not a int number
            {
                isValid = false;
                MessageBox.Show(name + " should be a whole number", "input error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (val < 0) // negative
            {
                isValid = false;
                MessageBox.Show(name + " should be a positive number", "input error");
                tb.SelectAll();
                tb.Focus();
            }

            return isValid;
        }

        /// <summary>
        /// check if text box contains non-negative double value
        /// </summary>
        /// <param name="tb">text box to validate</param>
        /// <param name="name">true is balid and false if not</param>
        public static bool IsNonNegativeDouble(TextBox tb, string name)
        {
            bool isValid = true;
            double val;
            if (!Double.TryParse(tb.Text, out val)) // not a double value
            {
                isValid = false;
                MessageBox.Show(name + " should be a whole number", "input error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (val < 0) // negative
            {
                isValid = false;
                MessageBox.Show(name + " should be a positive number", "input error");
                tb.SelectAll();
                tb.Focus();
            }

            return isValid;
        }
    }
}