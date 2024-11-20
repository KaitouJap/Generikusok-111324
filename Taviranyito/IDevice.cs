namespace Taviranyito
{
    public interface IDevice
    {
        void PowerOn();
        void PowerOff();
        bool VolumeUp();
        bool VolumeDown();
        bool ChangeChannel(byte channel);
    }
}