using System;

namespace JoyRumble.NET.App
{
    internal class Program
    {
        private static int mJoynumber, mStrong, mWeak, mDuration;
        private static Gamepad mGamepad;
        private static bool mRunAsync;

        static void Main(string[] args)
        {
            mJoynumber = int.Parse(args[0]);
            mStrong = int.Parse(args[1]);
            mWeak = int.Parse(args[2]);
            mDuration = int.Parse(args[3]);
            mRunAsync = bool.Parse(args[4]);

            mGamepad = new Gamepad();

            if (mRunAsync)
            {
                StartAsync();
                return;
            }

            mGamepad.Joyrumble(mJoynumber, mStrong, mWeak, mDuration);    
        }

        private static async void StartAsync()
        {
            await mGamepad.JoyrumbleAsync(mJoynumber, mStrong, mWeak, mDuration);
        }
    }
}