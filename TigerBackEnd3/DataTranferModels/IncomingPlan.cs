using Duende.IdentityServer.Extensions;
using TigerPhoneAPI.Models;

namespace TigerPhoneAPI.DataTranferModels
{
    public class IncomingPlan
    {
        public string PlanName { get; set; }
        public int DeviceLimit { get; set; }
        public int PlanPrice { get; set; }
        public ICollection<Device>? newDevices { get; set; }
        public Plan ToDataModel()
        {
            return new Plan
            {
                Devices = newDevices.IsNullOrEmpty() ? new List<Device>() : newDevices,
                PlanPrice = PlanPrice,
                PlanName = PlanName
            };
        }
    }
}
