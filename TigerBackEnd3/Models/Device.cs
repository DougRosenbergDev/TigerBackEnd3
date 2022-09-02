using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TigerPhoneAPI.Models
{
    public class Device
    {
        [Key]
        public int DeviceId { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string PhoneNumber { get; set; }
        public int PlanId { get; set; }
        [JsonIgnore]
        public virtual Plan? Plan { get; set; }
    }
}
