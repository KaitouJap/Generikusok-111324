using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generikusTaviranyito
{
    public class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            RemoteControl<TV> tvRemote = new RemoteControl<TV>(tv);

            tvRemote.ChangeChannel(5);
        }
    }
}
