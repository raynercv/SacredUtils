﻿using System.Diagnostics;
using System.Linq;

namespace SacredUtils.resources.bin
{
    public static class ApplicationRunSacredGameWithArgs
    {
        public static void Run(string[] args)
        {
            if (args.Contains("-cheats"))
            {
                Process.Start("Sacred.exe", "CHEATS=1");

                EnableSwitchingLanguage(args);
                EnableStretchingScreenshot(args);
                EnableEmulateHotkeys(args);
            }
            else
            {
                Process.Start("Sacred.exe");

                EnableSwitchingLanguage(args);
                EnableStretchingScreenshot(args);
                EnableEmulateHotkeys(args);
            }
        }

        private static void EnableSwitchingLanguage(string[] args)
        {
            if (args.Contains("-forceSwitchLanguage"))
            {
                ForceSwitchKeyboardLanguageInGame.RegisterApplication();
            }
        }

        private static void EnableStretchingScreenshot(string[] args)
        {
            if (args.Contains("-fullScreenShot"))
            {
                ForceStretchSacredGameScreenshot.RegisterKey(true);
            }
        }

        private static void EnableEmulateHotkeys(string[] args)
        { 
            if (args.Contains("-emulateHotkeys"))
            {
                // calling emulating hotkeys ...
            }
        }
    }
}