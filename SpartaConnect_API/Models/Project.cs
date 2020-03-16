using System;
using System.Collections.Generic;

namespace SpartaConnect_API.Models
{
    public partial class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int? ConsultantId { get; set; }
        public string ProjectDescription { get; set; }

        public virtual Consultant Consultant { get; set; }
    }
}
