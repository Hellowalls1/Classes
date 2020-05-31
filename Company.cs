using System;
using System.Collections.Generic;

namespace classes {

    public class Company {
        public DateTime _dateFounded { get; set; }

        public string _companyName { get; set; }

        //Employee is the list Type
        public List<Employee> _employeeList = new List<Employee> ();

        //method called "ListEmployee" to add newEmployees to 
        //Employee is the Type and newEmployee is the parameter
        public void ListEmployee (Employee newEmployee) {
            _employeeList.Add (newEmployee);
        }

        //method for displaying the DateTime
        public void Date () {
            _dateFounded = DateTime.Now;
        }
    }
}