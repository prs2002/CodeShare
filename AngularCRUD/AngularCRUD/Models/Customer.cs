using System.ComponentModel.DataAnnotations;

namespace AngularCRUD.Models
{
    public class Customer
    {
        [Key]
        public int Cid { get; set; }
        public string Cname { get; set; }
        public decimal Sal { get; set; }
        public DateTime Doj { get; set; }
        public string City { get; set; }
        public int DeptId { get; set; }

        public Department Department { get; set; }
    }
}
