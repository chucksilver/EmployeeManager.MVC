using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManager.MVC.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Column("EmployeeID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Employee ID is required")]
        [Display(Name = "Employee ID")]
        public int EmployeeId { get; set; }
        [Column("FirstName")]
        [Display(Name ="First Name")]
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(10,ErrorMessage ="First Name must be less than 10 characters")]
        public string FirstName { get; set; }
        [Column("LastName")]
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(10, ErrorMessage = "Last Name must be less than 20 characters")]
        public string LastName { get; set; }
        [Column("Title")]
        [Display(Name = "Title")]
        [Required(ErrorMessage = "Title is required")]
        [StringLength(10, ErrorMessage = "Title must be less than 30 characters")]
        public string Title { get; set; }
        [Column("BirthDate")]
        [Display(Name = "Birth Date")]
        [Required(ErrorMessage ="Birth Date is required")]
        public DateTime BirthDate {get;set;}
        [Column("HireDate")]
        [Display(Name ="HIre Date")]
        [Required(ErrorMessage ="Hired Date is requried")]
        public DateTime HireDate { get; set; }
        [Column("Country")]
        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country is required")]
        [StringLength(15, ErrorMessage = "Country must be less than 15 characters")]
        public string Country { get; set; }
        [Column("Notes")]
        [Display(Name ="Notes")]
        [StringLength(500, ErrorMessage = "Note must be less than 500 characters")]
        public string Note { get; set; }
    }
}
