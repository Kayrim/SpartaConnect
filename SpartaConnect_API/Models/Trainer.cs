using System;
using System.Collections.Generic;

namespace SpartaConnect_API.Models
{
    public partial class Trainer
    {
        public Trainer()
        {
            TrainerCourses = new HashSet<TrainerCourses>();
        }

        public int TrainerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Photo { get; set; }
        public string Bio { get; set; }

        public virtual ICollection<TrainerCourses> TrainerCourses { get; set; }
    }
}
