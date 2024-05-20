using Chefaa.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chefaa.Core.Models
{
    public class Schedule : BaseEntity
    {
        public double Price { get; set; }

        public Day ScheduleDay { get; set; }

        public TimeSpan ScheduleTime { get; set; }

        public int DoctorId { get; set; }

        public virtual Doctor? Doctor { get; set; }
    }
}
