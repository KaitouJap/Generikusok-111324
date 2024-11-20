using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generikusTaviranyito
{
    public class RemoteControl<T> where T : IDevice
    {
        T device;

        public RemoteControl(T device)
        {
            this.device = device;
        }

        public void PowerOn()
        {
            device.PowerOn();
            Console.WriteLine(device.name+" is now powered on!");
        }

        public void PowerOff()
        {
            device.PowerOff();
            Console.WriteLine(device.name+"is now powered off!");
        }

        public void ChangeChannel(int channel)
        {
            Console.WriteLine($"Channel changed to {device.channel} on {device.name}");
        }

        public void VolumeUp()
        {
            Console.WriteLine($"Volume increased on {device.name}");
        }
        public void VolumeDown()
        {
            Console.WriteLine($"Volume decreased on {device.name}");
        }
    }
}
