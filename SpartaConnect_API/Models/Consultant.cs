using System;
using System.Collections.Generic;

namespace SpartaConnect_API.Models
{
    public partial class Consultant
    {
        public Consultant()
        {
            Project = new HashSet<Project>();
        }

        public int ConsultantId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int? CourseId { get; set; }
        public string Photo { get; set; }
        public string Bio { get; set; }
        public string University { get; set; }
        public string CvLink { get; set; }
        public string VideoLink { get; set; }

        public virtual Course Course { get; set; }
        public virtual ICollection<Project> Project { get; set; }
    }
}
