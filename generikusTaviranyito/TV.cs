using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace generikusTaviranyito
{
    internal class TV : IDevice
    {

        public byte? volume 
        {
            get
            {
                return isPowered ? volume : null;
            }
            private set
            {
                volume = isPowered && (volume + value) <= byte.MaxValue && (volume - value) >= byte.MinValue ? value : volume;
            }
        }
        public byte? channel
        {
            get
            {
                return isPowered ? channel : null;
            }
            private set
            {
                channel = isPowered && value <= byte.MaxValue && value >= byte.MinValue ? value : channel;
            }
        }
        public bool isPowered
        {
            get
            {
                return isPowered;
            }
            set
            {
                isPowered = value;
            }
        }

        public string name { get => "TV"; }
        public TV()
        {
            isPowered = false;
            volume = null;
            channel = null;
        }
        public void ChangeChannel(byte channel)
        {
            this.channel = channel; 
        }

        public void PowerOff()
        {
            isPowered = false;
        }

        public void PowerOn()
        {
            isPowered = true;
        }

        public void VolumeDown()
        {
            volume -= 1;
        }

        public void VolumeUp()
        {
            volume += 1;
        }
    }
}
