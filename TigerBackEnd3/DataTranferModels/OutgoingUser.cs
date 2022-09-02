using TigerPhoneAPI.Models;

namespace TigerPhoneAPI.DataTranferModels
{
    public class OutgoingUser
    {
        public int UserId { get; set; }
        public List<Plan>? Plans { get; set; }
        public List<Device>? Devices { get; set; }
        public OutgoingUser(User dataModel)
        {
            UserId = dataModel.UserId;
            Plans = dataModel.Plans.ToList();
            foreach (var plan in Plans)
            {
                if (plan.Devices != null)
                {
                    Devices.AddRange(plan.Devices);
                }
            };
        }
    }
}
