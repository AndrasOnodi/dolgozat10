using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Models
{
    public class Class1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Job { get; set; }
        public string Salary { get; set; }

        public Class1() { }

        public Class1(int id, string name, string city, string job, string salary)
        {
            Id = id;
            Name = name;
            City = city;
            Job = job;
            Salary = salary;
        }

        public override string? ToString()
        {
            return Name + "; " + City + "; " + Job + "; " + Salary;
        }
    }
}
