﻿using System.Diagnostics;
using static SacredUtils.SourceFiles.settings.ApplicationSettingsManager;

namespace SacredUtils.SourceFiles.dlg
{
    public partial class ApplicationDonateSelectDialog
    {
        public ApplicationDonateSelectDialog()
        {
            InitializeComponent(); EventSubscribe();
        }

        private void EventSubscribe()
        {
            QiwiButton.Click += (s, e) => OpenLink("https://qiwi.me/mairwunnx");
            YandexButton.Click += (s, e) => OpenLink("https://money.yandex.ru/to/410015993365458");
        }

        private void OpenLink(string link)
        {
            Process.Start(link);

            if (Settings.CloseDonateDialogAfterSelect)
            {
                BaseDialog.IsOpen = false;
            }
        }
    }
}
