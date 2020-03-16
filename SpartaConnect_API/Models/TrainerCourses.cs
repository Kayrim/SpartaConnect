using System;
using System.Collections.Generic;

namespace SpartaConnect_API.Models
{
    public partial class TrainerCourses
    {
        public int TrainerId { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}
