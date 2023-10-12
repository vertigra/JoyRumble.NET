using System.Runtime.InteropServices;

namespace JoyRumble.NET
{


    internal class Program
    {
        static void Main(string[] args)
        {
            ImportHelpers.Joyrumble(0, 8000, 500, 10);
        }
    }
}