﻿using System.Threading.Tasks;

namespace JoyRumble.NET
{
    /// <summary>
    /// joyrumble.so wrapper
    /// </summary>
    public static class Gamepad
    {
        /// <summary>
        /// Causes the joystick to vibrate synchronously
        /// </summary>
        /// <param name="joynumber">Joystick number (1-8). Notice the joystick number starts from 1. 1=/dev/input/js0 , 2=/dev/input/js1, and so on.</param>
        /// <param name="strong">strong motor intensity (0-100)</param>
        /// <param name="weak">weak motor intensity (0-100)</param>
        /// <param name="duration">duration in miliseconds</param>
        public static void Joyrumble(int joynumber, int strong, int weak, int duration)
        {
            ImportHelpers.Joyrumble(joynumber, strong, weak, duration);
        }
    }
}