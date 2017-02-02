using System;
using Gecko;

namespace Jackal
{
    public class Gecko33 : IDisposable
    {
        public GeckoWebBrowser WebBrowser { get; private set; }

        public Gecko33()
        {
            WebBrowser = new GeckoWebBrowser();
            WebBrowser.CreateWindow += OnCreateWindow;
        }

        public static void Initialize()
        {
            //Отключаем контейнер плагинов
            Environment.SetEnvironmentVariable("MOZ_DISABLE_OOP_PLUGINS", "1", EnvironmentVariableTarget.Process);

            //Запускаем XULRunner
            Xpcom.Initialize("xulrunner-33.0.en-US.win32");

            //This setting enables the dump function, which sends messages to the system console. 
            //Set it to true to enable it, or false to disable it.
            GeckoPreferences.User["browser.dom.window.dump.enabled"] = false;

            //A boolean value that indicates whether or not an alert should be shown when downloads complete.
            GeckoPreferences.User["browser.download.manager.showAlertOnComplete"] = false; //-45

            //A boolean value that indicates whether or not to delete the temporary file used 
            //by the Download Manager after the download is complete.
            GeckoPreferences.User["browser.helperApps.deleteTempFileOnExit"] = true;

            //By disabling the navigator permission, it automatically accepts the request, without poping up the dialog.
            GeckoPreferences.User["media.navigator.enabled"] = true;
            GeckoPreferences.User["media.navigator.permission.disabled"] = true;

            //true  - Show an error page for pages that couldn't be loaded. (Default)
            //false - Display an alert when a page can't be loaded and remain on the previous page.
            GeckoPreferences.User["browser.xul.error_pages.enabled"] = true;

            //Включить все плагины по-умолчанию и без вопроса об активации
            GeckoPreferences.User["plugin.state.flash"] = 2;

            //Запретить цепляние плагинов из HKEY_LOCAL_MACHINE\SOFTWARE\MozillaPlugins
            //Также есть некоторые плагины, которые Firefox проверяет независимо от этой ветки.
            GeckoPreferences.User["plugin.scan.plid.all"] = false;
            GeckoPreferences.User["plugin.scan.Acrobat"] = "999.0";
            GeckoPreferences.User["plugin.scan.SunJRE"] = "999.0";
            GeckoPreferences.User["plugin.scan.Quicktime"] = "999.0";
            GeckoPreferences.User["plugin.scan.WindowsMediaPlayer"] = "999.0";

            //CSS Font Loading (для нормального отображения шрифтов в  pdf.js)
            GeckoPreferences.User["layout.css.font-loading-api.enabled"] = false;

            //Разрешаем все плагины
            GeckoPreferences.Default["extensions.blocklist.enabled"] = false;
            GeckoPreferences.User["browser.download.manager.folderList"] = 0;
            GeckoPreferences.User["browser.download.manager.showWhenStarting"] = true;
            GeckoPreferences.User["browser.download.manager.useWindow"] = true;
            GeckoPreferences.User["browser.download.manager.openDelay"] = 0;

            //Useragent
            GeckoPreferences.User["general.useragent.override"] = "Mozilla/5.0 (Windows NT 6.1; rv:22.0) Gecko/20130405 Firefox/22.0";


            //Разрешаем использование невалидных сертификатор
            CertOverrideService.GetService().ValidityOverride += (s, e) =>
            {
                e.OverrideResult = CertOverride.Mismatch | CertOverride.Time | CertOverride.Untrusted;
                e.Temporary = true;
                e.Handled = true;
            };
        }

        private void OnCreateWindow(object sender, GeckoCreateWindowEventArgs e)
        {
            Navigate(e.Uri);
            e.Cancel = true;
        }

        private bool TryCreateUri(string uriString, out Uri uri)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(uriString, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
           

            if (!result)
            {
                uri = new Uri("https://www.google.com/search?q=" + uriString);
            }
            else
            {
                uri = uriResult;
            }

            return result;
        }

        public void Navigate(string uriString, string referrer = "")
        {
            Uri uri;
            TryCreateUri(uriString, out uri);

            WebBrowser.Navigate(uri.AbsoluteUri, GeckoLoadFlags.None, referrer, null);
        }

        public void Dispose()
        {
            if (WebBrowser != null)
            {
                WebBrowser.Dispose();
            }
        }
    }
}