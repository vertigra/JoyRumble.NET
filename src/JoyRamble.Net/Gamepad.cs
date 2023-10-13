using System.Security.Cryptography;
using System;
using System.Threading.Tasks;

namespace JoyRumble.NET
{
    public class Gamepad
    {
        public void Joyrumble(int joynumber, int strong, int weak, int duration)
        {
            ImportHelpers.Joyrumble(joynumber, strong, weak, duration);
        }

        public Task JoyrumbleAsync(int joynumber, int strong, int weak, int duration)
        {
            return Task.Run(() => ImportHelpers.Joyrumble(joynumber, strong, weak, duration));
        }
    }
}