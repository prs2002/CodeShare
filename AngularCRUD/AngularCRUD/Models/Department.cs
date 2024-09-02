using System.ComponentModel.DataAnnotations;

namespace AngularCRUD.Models
{
    public class Department
    {
        [Key]
        public int Did { get; set; }
        public string Dname { get; set; }
        public string City { get; set; }

        public ICollection<Customer> Customers { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
