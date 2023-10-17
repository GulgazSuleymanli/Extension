using Extension.Models;
using Extention.Models;

namespace Extention
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            string name;
            byte age;
            double salary;
            Department department=new Department(8);
            do
            {
                Console.WriteLine("1 - Show all employees");
                Console.WriteLine("2 - Add new employee");
                Console.WriteLine("3 - Show employee by id");
                Console.WriteLine("4 - Show employee by code");
                Console.WriteLine("5 - Show employee for salary");
                Console.WriteLine("6 - Remove employee");
                Console.WriteLine("0 - Exit");

                string input= Console.ReadLine();

                switch (input)
                {
                    case "1":
                        department.ShowAllEmployees();
                        break;

                    case "2":
                        do
                        {
                            Console.WriteLine("Insert name of employee");
                            name = Console.ReadLine();
                        }
                        while (name.Length < 3);

                        do
                        {
                            Console.WriteLine("Insert age of employee");
                            age = byte.Parse(Console.ReadLine());
                        }
                        while (age < 18);

                        do
                        {
                            Console.WriteLine("Insert salary of employee");
                            salary = double.Parse(Console.ReadLine());
                        }
                        while (salary < 200);

                        Employee employee= new Employee(name, age, salary);
                        department.AddEmployee(employee);
                        break;

                    case "3":
                        if(department != null)
                        {
                            Console.WriteLine("Insert search by id");
                            int id = int.Parse(Console.ReadLine());
                            department.ShowEmployeeById(id);
                        }
                        else
                        {
                            Console.WriteLine("Please, first add employee");
                        }
                        break;

                    case "4":
                        if(department != null)
                        {
                            Console.WriteLine("Insert search by id");
                            string code = Console.ReadLine();
                            department.ShowEmployeeByCode(code);
                        }
                        else
                        {
                            Console.WriteLine("Please, first add employee");
                        }
                        break;

                    case "5":
                        if(department != null)
                        {
                            Console.WriteLine("Insert min value for search by salary");
                            int min = int.Parse(Console.ReadLine());
                            Console.WriteLine("Insert max value for search by salary");
                            int max = int.Parse(Console.ReadLine());
                            department.ShowEmployeeForSalary(min, max);
                        }
                        else
                        {
                            Console.WriteLine("Please, first add employee");
                        }
                        break;

                    case "6":
                        if(department != null)
                        {
                            Console.WriteLine("Insert employee id for remove");
                            int id= int.Parse(Console.ReadLine());
                            department.RemoveEmployee(id);
                        }
                        else
                        {
                            Console.WriteLine("Please, first add employee");
                        }
                        break;
                }
            }
            while (check);
        }
    }
}