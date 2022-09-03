using System.ComponentModel.DataAnnotations;

namespace TigerPhoneAPI.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public virtual ICollection<Plan> Plans { get; set; }
    }
}
