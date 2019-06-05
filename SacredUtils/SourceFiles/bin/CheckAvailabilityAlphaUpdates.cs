﻿using SacredUtils.SourceFiles;
using SacredUtils.SourceFiles.bin;
using SacredUtils.SourceFiles.utils;
using static SacredUtils.SourceFiles.Logger;

namespace SacredUtils.resources.bin
{
    public static class CheckAvailabilityAlphaUpdates
    {
        public static void GetPerm()
        {
            if (!NetworkUtils.IsConnected.Value) return;

            Log.Info("Checking permission for checking alpha SacredUtils updates ...");

            if (AppSettings.ApplicationSettings.CheckAutoAlphaUpdate)
            {
                if (GetActualApplicationVersion.Get("alpha", ApplicationInfo.AlphaVersion,
                    "https://drive.google.com/uc?export=download&id=1Fc0QIxzUn7-ellW5e4_W1Wv05-V1hsJ8"))
                {
                    DownloadApplicationNewUpdate.Download(
                        "https://drive.google.com/uc?export=download&id=1xZzaj0v41S7nkSXkn4GWoDTkBtzeRc2Y",
                        "alpha");
                }
                else
                {
                    CheckAvailabilityReleaseUpdates.GetPerm();
                }
            }
            else
            {
                CheckAvailabilityReleaseUpdates.GetPerm(); 
            }
        }
    }
}
