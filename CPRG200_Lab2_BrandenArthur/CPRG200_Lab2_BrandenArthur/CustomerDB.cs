using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class CustomerDataDB
    {
        const string path = "customers.txt";

        public static List<Customer> ReadCustomers()
        {
            List<Customer> customers = new List<Customer>();
            Customer cust;
            int accountNo;
            string custName;
            string custType;
            double charge;
            string line;
            string[] fields;

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using(StreamReader sr = new StreamReader(fs))
                {
                    while(!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        fields = line.Split(',');
                        accountNo = Convert.ToInt32(fields[0]);
                        custName = fields[1];
                        custType = fields[2];
                        charge = Convert.ToDouble(fields[3]);

                        cust = new Customer(accountNo, custName, custType, charge);
                        customers.Add(cust);
                    }
                }
            }
            return customers;
        }

        public static void SaveCustomers(List<Customer> customers)
        {
            string line;
            using(FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using(StreamWriter sw = new StreamWriter(fs))
                {
                    foreach(Customer c in customers)
                    {
                        sw.WriteLine(c.ToFileString());
                    }
                }
            }
        }
    }
    
}
