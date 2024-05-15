using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace student_staff_console_application
{
    internal class Student(string name, string address, string program, int year, double fee) : Person(name, address)
    {
        public string Program { get; private set; } = program;
        public int Year { get; private set; } = year;
        public double Fee { get; private set; } = fee;

        public string GetProgram()
        {
            return Program;
        }

        public void SetProgram(string program)
        {
            Program = program;
        }

        public int GetYear()
        {
            return Year;
        }

        public void SetYear(int year)
        {
            Year = year;
        }

        public double GetFee()
        {
            return Fee;
        }

        public void SetFee(double fee)
        {
            Fee = fee;
        }

        public override string ToString()
        {
            return $"Student[Person[name={Name}, address={Address}], program={Program}, year={Year}, fee={Fee}]";
        }
    }
}
