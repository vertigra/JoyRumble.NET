using System.Runtime.InteropServices;

namespace JoyRumble.NET
{


    internal class Program
    {
        static void Main(int[] args)
        {
            ImportHelpers.Joyrumble(args[0], args[1], args[2], args[3]);
        }
    }
}