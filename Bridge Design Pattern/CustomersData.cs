using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Design_Pattern
{
    public class CustomersData : IDataObject<string>
    {
        private readonly string city;
        private readonly List<string> customers;
        private int current = 0;

        // Constructor
        public CustomersData(string city)
        {
            this.city = city;

            // Simulate loading from database
            customers =
                  ["Jim Jones", "Samual Jackson", "Allan Good",
                "Ann Stills", "Lisa Giolani" ];
        }

        public void NextRecord()
        {
            if (current <= customers.Count - 1)
            {
                current++;
            }
        }

        public void PriorRecord()
        {
            if (current > 0)
            {
                current--;
            }
        }

        public void AddRecord(string customer) =>
            customers.Add(customer);

        public void DeleteRecord(string customer) =>
            customers.Remove(customer);

        public string GetCurrentRecord() =>
            customers[current];

        public void ShowRecord() =>
            Console.WriteLine(customers[current]);

        public void ShowAllRecords()
        {
            Console.WriteLine("Customer Group: " + city);
            customers.ForEach(customer =>
                Console.WriteLine(" " + customer));
        }
    }
}
