using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //một sinh viên có nhiều khóa học
        //chỉ đến bảng Enrollment
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}