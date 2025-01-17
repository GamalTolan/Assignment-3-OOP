using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_OOP.Part_2
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityLevel Security { get; set; }
        public int Salary { get; set; }
        public HiringDate HireDate { get; set; }
        public Gender Gender { get; set; }


        public Employee(int id, string name, SecurityLevel security, int salary, HiringDate hireDate, Gender gender)
        {

            if (id < 0)
                throw new ArgumentOutOfRangeException("Enter Correct id");
            if (name == null) 
                throw new ArgumentNullException("Enter the Name");
            if (salary<2000)
                throw new ArgumentNullException("Salary must be >2000");
           
            ID = id;
            Name = name;
            Security = security;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;

        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Security Level: {Security}, Salary: {Salary.ToString("C", CultureInfo.CurrentCulture)},Hire Date: {HireDate}, Gender: {Gender}";
        }
    }

    
}
