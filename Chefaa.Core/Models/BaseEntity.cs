using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Chefaa.Core.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [JsonIgnore]
        public bool IsActive { get; set; } = true;

        [JsonIgnore]
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;

        [JsonIgnore]
        public DateTime? ModifiedDate { get; set; }
    }
}
