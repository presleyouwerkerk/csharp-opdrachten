using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStaffConsoleApplication
{
    internal class Staff(string name, string address, string school, double pay) : Person(name, address)
    {
        public string School { get; private set; } = school;
        public double Pay { get; private set; } = pay;

        public string GetSchool()
        {
            return School;
        }

        public void SetSchool(string school)
        {
            School = school;
        }

        public double GetPay()
        {
            return Pay;
        }

        public void SetPay(double pay)
        {
            Pay = pay;
        }

        public override string ToString()
        {
            return $"Staff : name={Name}, address={Address}, school={School}, pay={Pay}";
        }
    }
}
