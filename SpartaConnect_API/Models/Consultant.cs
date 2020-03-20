using System;
using System.Collections.Generic;

namespace SpartaConnect_API.Models
{
    public partial class Consultant
    {
        public int ConsultantId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Bio { get; set; }
        public string University { get; set; }
        public string Degree { get; set; }
        public string Grade { get; set; }
        public string Stream { get; set; }
        public string CvLink { get; set; }
        public string VideoLink { get; set; }
        public string PhotoLink { get; set; }
    }
}
