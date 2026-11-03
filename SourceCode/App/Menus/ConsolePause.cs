using System;

namespace Habbo_Downloader.App.Menus
{
    /// <summary>
    /// "Press any key" pauses for the console menus. Console.ReadKey throws when the input is not a keyboard
    /// (stdin redirected: a script, a pipe, an SSH command without a terminal), which ended the program in the middle
    /// of a "DOWNLOAD ALL". Then there is nobody to press a key, so the pause is skipped.
    /// </summary>
    internal static class ConsolePause
    {
        public static void WaitForKey(string message)
        {
            if (Console.IsInputRedirected)
            {
                return;
            }

            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
