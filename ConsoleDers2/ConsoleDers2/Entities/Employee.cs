using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDers2.Entities
{
    internal class Employee
    {
        [Key]
        public int EmployeID { get; set; }
        public string EmployeName { get; set; }
    }
}
