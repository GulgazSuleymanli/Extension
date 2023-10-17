using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension.Models
{
    internal class Department
    {
        public int EmployeeLimit { get; set; }
        Employee[] Employees= new Employee[0];

        public Department(int empLimit)
        {
            EmployeeLimit = empLimit;
        }

        public void AddEmployee(Employee employee)
        {
            if(Employees.Length <= EmployeeLimit)
            {
                Array.Resize(ref Employees, Employees.Length);
                Employees[Employees.Length - 1] = employee;
            }
            else
            {
                Console.WriteLine("Department is full");
            }
        }

        public void ShowAllEmployees()
        {
            foreach (Employee emp in Employees)
            {
                Console.WriteLine(emp);
            }
        }

        public void ShowEmployeeById(int id)
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                if(Employees[i].Id == id)
                {
                    Console.WriteLine(Employees[i]);
                }
            }
        }

        public void ShowEmployeeByCode(string code)
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].EmployeeCode == code)
                {
                    Console.WriteLine(Employees[i]);
                }
            }
        }

        public void ShowEmployeeForSalary(int min, int max)
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].Salary >= min && Employees[i].Salary <= max)
                {
                    Console.WriteLine(Employees[i]);
                }
            }
        }

        public void RemoveEmployee(int id)
        {
            Employee[] emps=new Employee[0];
            for (int i = 0;i < Employees.Length;i++)
            {
                if (Employees[i].Id != id)
                {
                    Array.Resize(ref emps, emps.Length+1);
                    emps[emps.Length-1]= Employees[i];
                }
            }
            Employees = emps;
        }
    }
}
