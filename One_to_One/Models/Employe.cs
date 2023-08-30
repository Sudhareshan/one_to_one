using System.ComponentModel.DataAnnotations;

namespace One_to_One.Models
{
    public class Employe
    {
        [Key]
        public int EmployeId { get; set; }

        public string? EmployeName { get; set; }

        public DateTime JoinDate { get; set; }

        //Navigation property Returns the AdharDeatails object
        public virtual AdharDeatails? AdharDeatails { get; set; }
    }
}
