using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartaConnectMVC.Models
{
    public class ConsultantViewModel
    {
        public int ConsultantId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int? CourseId { get; set; }
        public string Photo { get; set; }
        public string Bio { get; set; }
        public string University { get; set; }
        public string CvLink { get; set; }
        public string VideoLink { get; set; }
        public string CourseName { get; set; }
    }
}
