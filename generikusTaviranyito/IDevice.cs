using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generikusTaviranyito
{
    public interface IDevice
    {
        string name { get;}
        byte? volume { get;}
        byte? channel { get;}
        bool isPowered { get;}

        void PowerOn();
        void PowerOff();
        void VolumeUp();
        void VolumeDown();
        void ChangeChannel(byte channel);
    }
}
