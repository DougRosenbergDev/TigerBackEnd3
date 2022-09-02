using TigerPhoneAPI.Models;

namespace TigerPhoneAPI.DataTranferModels
{
    public class IncomingDevice
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string PhoneNumber { get; set; }
        public Device ToDataModel()
        {
            return new Device
            {
                Type = Type,
                Model = Model,
                PhoneNumber = PhoneNumber,
            };
        }
    }
}
