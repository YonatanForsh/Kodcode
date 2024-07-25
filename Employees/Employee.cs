using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Employee

    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }   
        public string Id { get; set; }
        public DateTime Birthday { get; set; }
        public int Age { get { return DateTime.Now.Year - Birthday.Year; } }
        public int EmployeeNum { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNum { get; set; }
        public string IsMale { get; set; }
        public string Status { get; set; }


        public Employee() { }
        
        public Employee(string firstName, string lastName, string id, DateTime birthday, int employeeNum, string phone, string city, string street, int houseNum, string is_male, string status) {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Birthday = birthday;
            EmployeeNum = employeeNum;
            Phone = phone;
            City = city;
            Street = street;
            HouseNum = houseNum;
            IsMale = is_male;
            Status = status;

        }

    }
}
