using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    public class Student
    {
        [Key]
        [DisplayName("Student Id")]
        public int Id { get; set; }

        [DisplayName("Student Name")]
        [Column(TypeName = "nvarchar(30)")]
        [Required(ErrorMessage = "This Field is Required.")]
        public string Name { get; set; }

        [DisplayName("Date of Birth")]
        [Required(ErrorMessage = "This Field is Required.")]
        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime Dob { get; set; }

        [DisplayName("Student Email Id")]
        [Column(TypeName = "nvarchar(30)")]
        [Required(ErrorMessage ="This Field is Required.")]
        public String Email { get; set; }

        [DisplayName("Department Name")]
        [Column(TypeName = "nvarchar(30)")]
        [Required(ErrorMessage = "This Field is Required.")]
        public string Department { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Required(ErrorMessage = "This Field is Required.")]
        public decimal Fees { get; set; }
    }
}
