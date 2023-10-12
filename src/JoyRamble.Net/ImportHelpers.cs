using System.Runtime.InteropServices;

internal static class ImportHelpers
{

    [DllImport("joyrumble.so", EntryPoint = "joyrumble")]
    public static extern int Joyrumble(int joynumber, int strong, int weak, int duration);
}