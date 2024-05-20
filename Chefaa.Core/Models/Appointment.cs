using Chefaa.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chefaa.Core.Models
{
    public class Appointment : BaseEntity
    {
        public DateTime AppointmentDate { get; set; }
        public Day AppointmentDay { get; set; }
        public Status Status { get; set; }

        public int? DiscountCodeId { get; set; }
        public virtual DiscountCode? DiscountCode { get; set; }

        public int DoctorId { get; set; }
        public virtual Doctor? Doctor { get; set; }

        public int PatientId { get; set; }
        public virtual Patient? Patient { get; set; }
    }
}
