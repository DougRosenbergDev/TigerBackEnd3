using System.ComponentModel.DataAnnotations;

namespace TigerPhoneAPI.Models
{
    public class Plan
    {
        [Key]
        public int PlanId { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
    }
}
