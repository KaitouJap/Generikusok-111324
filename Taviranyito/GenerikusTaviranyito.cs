using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taviranyito
{
    public class GenerikusTaviranyito<T> where T : IDevice
    {
        T device;

        public GenerikusTaviranyito(T device)
        {
            this.device = device;
        }

        public void PowerOn()
        {
            device.PowerOn();
            Console.WriteLine($"{device.GetType()} is now powered on!");
        }
        public void PowerOff()
        {
            device.PowerOff();
            Console.WriteLine($"{device.GetType()} is now powered off!");
        }
        public void ChangeChannel(byte channel)
        {
            try
            {
                if (device.ChangeChannel(channel))
                    Console.WriteLine($"Channel changed to {channel} on {device.GetType()}!");
                else
                    Console.WriteLine($"{device.GetType()} is turned off!");
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void VolumeUp()
        {
            if(device.VolumeUp())
                Console.WriteLine($"Volume increased on {device.GetType()}");
            else
                Console.WriteLine($"{device.GetType()} is turned off!");
        }
        public void VolumeDown()
        {
            if(device.VolumeDown())
                Console.WriteLine($"Volume decreased on {device.GetType()}!");
            else
                Console.WriteLine($"{device.GetType()} is turned off!");
        }
    }
}
