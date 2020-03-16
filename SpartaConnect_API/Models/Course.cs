using System;
using System.Collections.Generic;

namespace SpartaConnect_API.Models
{
    public partial class Course
    {
        public Course()
        {
            Consultant = new HashSet<Consultant>();
            TrainerCourses = new HashSet<TrainerCourses>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int? CatgeoryId { get; set; }
        public string LengthOfCourse { get; set; }
        public string CourseDescription { get; set; }

        public virtual Category Catgeory { get; set; }
        public virtual ICollection<Consultant> Consultant { get; set; }
        public virtual ICollection<TrainerCourses> TrainerCourses { get; set; }
    }
}
