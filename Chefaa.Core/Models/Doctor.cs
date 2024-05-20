using Chefaa.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chefaa.Core.Models
{
    public class Doctor : BaseEntity
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Image { get; set; } = null!;

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        public string PhoneNumber { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        public int SpecializationId { get; set; }
        public virtual Specialization? SpecializationId { get; set; }

        public virtual List<Appointment>? Appointments { get; set; }

        public virtual List<Schedule>? Schedules { get; set; }

    }
}
