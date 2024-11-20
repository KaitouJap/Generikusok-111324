using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taviranyito
{
    public class Hifi : IDevice
    {
        bool isPowered;
        byte channel;
        byte volume;

        public Hifi()
        {
            isPowered = false;
            channel = 0;
            volume = 0;
        }
        public bool ChangeChannel(byte channel)
        {
            throw new NotImplementedException();
        }

        public void PowerOff()
        {
            isPowered = false;
        }

        public void PowerOn()
        {
            isPowered = true;
        }

        public bool VolumeDown()
        {
            if (isPowered)
                --volume;
            return isPowered;
        }

        public bool VolumeUp()
        {
            if (isPowered)
                ++volume;
            return isPowered;
        }
    }
}
