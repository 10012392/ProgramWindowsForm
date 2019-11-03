//Lara Corkery 10012392
//Customer Class File
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentApplication
{
    class Customer
    {
        //Properties
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }

        //Constructor
        public Customer(string fn, string ln, string ph)
        {
            FName = fn;
            LName = ln;
            Phone = ph;
        }

        //Method
        public string GetCustomer()
        {
            return $"{FName}\t{LName}\t{Phone}";

        }
    }
}
