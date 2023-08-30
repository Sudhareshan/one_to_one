using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace One_to_One.Models
{
    public class AdharDeatails
    {
        [Key,ForeignKey("Employe")]
        public int EmployeId { get; set; }
        public long AdharNumber { get; set; }

        //Navigation property Returns the Employee object
        public virtual Employe? Employe { get; set; }
    }
}