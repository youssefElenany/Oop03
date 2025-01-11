using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass03
{
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        private char gender;
        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'M' || value == 'F')
                    gender = value;
                else
                    throw new ArgumentException("Gender must be 'M' or 'F'.");
            }
        }
        public decimal Salary { get; set; }
        public HiringDate HireDate { get; set; }
        public SecurityLevel Security { get; set; }
        public Employee(int id, string name, char gender, decimal salary, HiringDate hireDate, SecurityLevel security)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Salary = salary;
            HireDate = hireDate;
            Security = security;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Salary: {Salary.ToString("C", CultureInfo.CurrentCulture)}, Hire Date: {HireDate}, Security Level: {Security}";
        }
    }

    public class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }

    }
}
