﻿namespace Device.TemperatureSensor
{
    internal class DeviceIdentityInfo
    {
        public string HubName { get; set; }

        public string GatewayHost { get; set; }

        public string DeviceId { get; set; }

        public Auth Auth { get; set; }
    }

    internal class Auth
    {
        public string Type { get; set; }

        public string KeyHandle { get; set; }
    }
}
