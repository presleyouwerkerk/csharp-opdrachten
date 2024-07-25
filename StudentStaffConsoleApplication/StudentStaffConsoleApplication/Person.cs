using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStaffConsoleApplication
{
    internal class Person(string name, string address)
    {
        public string Name { get; private set; } = name;
        public string Address { get; private set; } = address;

        public string GetName()
        {
            return Name;
        }

        public string GetAddress()
        {
            return Address;
        }

        public void SetAddress(string address)
        {
            Address = address;
        }

        public override string ToString()
        {
            return $"Person : name={Name}, address={Address}";
        }
    }
}
