using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
    public partial class Department
    {
        public Department()
        {
            Students = new HashSet<Student>();
            Departments = new HashSet<DepartmentSubject>();

        }
        [Key]
        public int DID { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        [InverseProperty("Department")]
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<DepartmentSubject> Departments { get; set; }
    }
}
