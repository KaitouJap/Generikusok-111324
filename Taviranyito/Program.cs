using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taviranyito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TV tV = new TV();
            GenerikusTaviranyito<TV> taviranyito = new GenerikusTaviranyito<TV>(tV);


            taviranyito.PowerOn();
            taviranyito.VolumeDown();
            taviranyito.VolumeUp();
            taviranyito.ChangeChannel(5);
            taviranyito.PowerOff();

            Hifi hifi = new Hifi();
            GenerikusTaviranyito<Hifi> hifiTaviranyito = new GenerikusTaviranyito<Hifi>(hifi);


            hifiTaviranyito.PowerOn();
            hifiTaviranyito.VolumeDown();
            hifiTaviranyito.VolumeUp();
            hifiTaviranyito.ChangeChannel(5);
            hifiTaviranyito.PowerOff();
        }
    }
}
