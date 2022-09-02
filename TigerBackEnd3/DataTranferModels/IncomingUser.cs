using Duende.IdentityServer.Extensions;
using TigerPhoneAPI.Models;

namespace TigerPhoneAPI.DataTranferModels
{
    public class IncomingUser
    {
        public ICollection<Plan>? newPlans { get; set; }
        public User ToDataModel()
        {
            return new User
            {
                Plans = newPlans.IsNullOrEmpty() ? new List<Plan>() : newPlans
            };
        }
    }
}
