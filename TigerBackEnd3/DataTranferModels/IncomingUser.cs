using Duende.IdentityServer.Extensions;
using TigerPhoneAPI.Models;

namespace TigerPhoneAPI.DataTranferModels
{
    public class IncomingUser
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public ICollection<Plan>? newPlans { get; set; }
        public User ToDataModel()
        {
            return new User
            {
                Plans = newPlans.IsNullOrEmpty() ? new List<Plan>() : newPlans,
                Email = Email,
                UserName = UserName
            };
        }
    }
}
