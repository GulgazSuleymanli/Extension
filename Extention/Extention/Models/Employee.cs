using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension.Models
{
    internal class Employee:IPerson
    {
		private string _name;

        public string Name 
        { 
            get
            {
                return _name;
            }
            set
            {
                if (value.Length >= 3)
                {
                    _name = value;
                }
            }
        }

        private byte _age;
        public byte Age 
        { 
            get
            {
                return _age;
            }
            set
            {
                if(value >= 18)
                {
                    _age = value;
                }
            }
        }

        public int Id { get; }
        public static int id;
        public static int count=100;
        public string EmployeeCode { get; }
        private double _salary;

        public double Salary
        {
            get 
            { 
                return _salary; 
            }
            set 
            { 
                if(value >= 200)
                {
                    _salary = value;
                }
            }
        }

        public Employee(string name, byte age, double salary)
        {
            id++;
            count++;
            Id = id;
            Name = name;
            Age = age;
            Salary = salary;
            EmployeeCode = char.ToUpper(name[0]) + char.ToUpper(name[1]) + count.ToString();
        }
        public string ShowInfo()
        {
           return $"Id: {Id}, Name: {Name}, Age: {Age}, Salart: {Salary}, Employee code: {EmployeeCode}";
        }

        public override string ToString()
        {
            return ShowInfo() ;
        }
    }
}
