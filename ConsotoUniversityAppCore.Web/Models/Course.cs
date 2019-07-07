using ConsotoUniversityAppCore.Web.Configuration;
using ConsotoUniversityAppCore.Web.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConsotoUniversityAppCore.Web.Models
{
    public class Course : DomainEntity<String>,IDateTracking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }

        public int DepartmentID { get; set; }      
        public Department Department { get; set; }   
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
        public DateTime Crt_Date { get; set; }
        public DateTime ChgeDate { get; set; }
    }
}
