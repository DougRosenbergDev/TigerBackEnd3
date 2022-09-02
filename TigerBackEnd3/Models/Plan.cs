using System.ComponentModel.DataAnnotations;

namespace TigerPhoneAPI.Models
{
    public class Plan
    {
        [Key]
        public int PlanId { get; set; }
        public string PlanName { get; set; }
        public int DeviceLimit { get; set; }
        public int PlanPrice { get; set; }
        public int UserId { get; set; }
        //public virtual User? User { get; set; }
        public virtual ICollection<Device>? Devices { get; set; }
    }
}
