using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention.Models
{
    internal class Student
    {
        public int Id { get; set; }
        static int count;
        public string Name { get; set; }
        public string Surname { get; set; }
        private string _groupNo;
        public string GroupNo 
        { 
            get
            {
                return _groupNo;
            }
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
            }
        }

        public Student(string name, string surname, string groupNo)
        {
            Name = name;
            Surname = surname;
            GroupNo = groupNo;
            count++;
            Id = count;
        }

        public static bool CheckGroupNo(string no)
        {
            if(no.Length == 5 && char.IsUpper(no[0]) && char.IsUpper(no[1])) 
            { 
                for(int i = 2; i < no.Length; i++)
                {
                    if (char.IsDigit(no[i]))
                    {
                        continue;
                    }
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public void StudentInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Surname: {Surname}, Group: {GroupNo}");
        }
    }
}
