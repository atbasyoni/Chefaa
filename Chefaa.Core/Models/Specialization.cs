using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chefaa.Core.Models
{
    public class Specialization : BaseEntity
    {
        public string Name { get; set; } = null!;

        public virtual List<Doctor> Doctors { get; set; }
    }
}
