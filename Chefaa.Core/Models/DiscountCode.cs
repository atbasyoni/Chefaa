using Chefaa.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chefaa.Core.Models
{
    public class DiscountCode : BaseEntity
    {
        public string Code { get; set; } = null!;

        public decimal Value { get; set; }

        public DiscountType Type { get; set; }

        public int NumOfCompletedRequests { get; set; }

        public int PatientId { get; set; }

        public virtual Patient? Patient { get; set; }

        public List<Appointment>? Appointments { get; set; }
    }
}
