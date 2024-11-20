using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taviranyito
{
    public class TV : IDevice
    {
        bool isPowered;
        byte channel;
        byte volume;

        public TV()
        {
            isPowered = false;
            channel = 0;
            volume = 0;
        }
        public bool ChangeChannel(byte channel)
        {
            if (isPowered)
                this.channel = channel;
            return isPowered;
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
