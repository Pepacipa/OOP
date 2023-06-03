using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using практика_5;

namespace DeviceController
{
    internal class DeviceController
    {
        private DeviceType deviceType;
        public static DeviceController StartDevice(DeviceType measurementType)
        {
            DeviceController controller = new DeviceController { deviceType = measurementType };
            return controller;
        }
        public DeviceController StopDevice()
        {
            return null;
        }
        public int TakeMeasurement()
        {
            Random random = new Random();
            return random.Next(1, 10);
        }
    }
}
