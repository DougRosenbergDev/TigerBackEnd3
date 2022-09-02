using System.ComponentModel.DataAnnotations;

namespace TigerPhoneAPI.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Plan> Plans { get; set; }
    }
}
