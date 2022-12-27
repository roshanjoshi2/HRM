using HRM.Enums;

namespace HRM.Models
{
    public class Employee
    {

        public string Name { get; set; }

        public Gender Sex { get; set; }

        public string Degisnation { get; set; }

        public string Department { get; set; }
        public DateTime JoiningDate { get; set; }

    }
}
