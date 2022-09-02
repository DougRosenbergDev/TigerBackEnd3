using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigerPhoneAPI.Models
{
    public class Device
    {
        [Key]
        public int DeviceId { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
    }
}
