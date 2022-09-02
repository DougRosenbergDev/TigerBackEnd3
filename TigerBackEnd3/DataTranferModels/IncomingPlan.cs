using Duende.IdentityServer.Extensions;
using TigerPhoneAPI.Models;

namespace TigerPhoneAPI.DataTranferModels
{
    public class IncomingPlan
    {
        public ICollection<Device>? newDevices { get; set; }
        public Plan ToDataModel()
        {
            return new Plan
            {
                Devices = newDevices.IsNullOrEmpty() ? new List<Device>() : newDevices
            };
        }
    }
}
