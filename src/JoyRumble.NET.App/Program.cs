namespace JoyRumble.NET.App
{
    internal class Program
    {
        private static int mJoynumber, mStrong, mWeak, mDuration;
        
        static void Main(string[] args)
        {
            mJoynumber = int.Parse(args[0]);
            mStrong = int.Parse(args[1]);
            mWeak = int.Parse(args[2]);
            mDuration = int.Parse(args[3]);

            Gamepad.Joyrumble(mJoynumber, mStrong, mWeak, mDuration);
            Console.ReadLine();
        }
    }
}