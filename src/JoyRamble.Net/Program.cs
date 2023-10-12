using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace JoyRumble.NET
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ImportHelpers.Joyrumble(int.Parse(args[0]), int.Parse(args[1]), int.Parse(args[2]), int.Parse(args[3]));
            Task.Delay(int.Parse(args[3])).Wait();
        }
    }
}