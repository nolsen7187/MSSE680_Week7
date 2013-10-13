using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationWebForms.Models
{
    public class Employee
    {
        public Employee()
        {
            this.WebUserTables = new HashSet<WebUserTable>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeePhone { get; set; }
        public string Employeetype { get; set; }

        public virtual ICollection<WebUserTable> WebUserTables { get; set; }
    }
}