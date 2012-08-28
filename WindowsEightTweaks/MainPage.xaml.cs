using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace WindowsEightTweaks
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            CheckRegistry();
        }

        private void CheckRegistry()
        {
            progressBar.Visibility = Windows.UI.Xaml.Visibility.Visible;
            progressBar.Value = 0;
            //This module checks the registry for the status of registry changes;
            //then (re)initializes their radio control
            string[] DesktopArrowsData = { "29", "String", "%SystemRoot%\\Blank.ico,0" };
            string[] AutoLoginData = { "", "", "" };
            string[] MetroStartData = { "", "", "" };
            string[] SmartScreenData = { "EnableSmartScreen", "REG_DWORD", "0" };

            DesktopArrows.IsOn = false;
            AutoLogin.IsOn = false;
            MetroStart.IsOn = false;
            SmartScreen.IsOn = false;

            if (RegistryContainsKey("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\explorer\\Shell Icons", DesktopArrowsData))
            {
                DesktopArrows.IsOn = true;
            }

            progressBar.Value = progressBar.Value+25;

            if (RegistryContainsKey("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", AutoLoginData))
            {
                AutoLogin.IsOn = true;
            }
            progressBar.Value = progressBar.Value + 25;
            if (RegistryContainsKey("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer", MetroStartData))
            {
                MetroStart.IsOn = true;
            }
            progressBar.Value = progressBar.Value + 25;
            if (RegistryContainsKey("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", SmartScreenData))
            {
                SmartScreen.IsOn = true;
            }
            progressBar.Value = progressBar.Value + 25;

          //  progressBar.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }

        private Boolean RegistryContainsKey(string Key, string[] Values)
        {
            return false;
        }

        public Nullable<bool> IsChecked { get; set; }

        private void SendEmail(object sender, RoutedEventArgs e)
        {
            //TODO: Send an Email
        }

        private void SaveApp(object sender, RoutedEventArgs e)
        {
            if (DesktopArrows.IsOn)
            {
            }

            else if (AutoLogin.IsOn)
            {
                /*RegistryKey key;
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
                key.SetValue("AutoAdminLogon", "1");
                key.SetValue("DefaultPassword", "Test");
                key.SetValue("DefaultUsername", "Test");
                key.Close();*/
            }
            else if (MetroStart.IsOn)
            {
                /*Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
                key.SetValue("GlobalFolderSettings", "{EF8AD2D1-AE36-11D1-B2D2-006097DF8C11}");
                key.SetValue("LVPopupSearchControl", "{fccf70c8-f4d7-4d8b-8c17-cd6715e37fff}");
                key.SetValue("FileOpenDialog", "{DC1C5A9C-E88A-4dde-A5A1-60F82A20AEF7}");
                key.SetValue("IconUnderline", "1");
                key.SetValue("DefaultPassword", "dword:00000002");
                key.SetValue("ListViewPopupControl", "{8be9f5ea-e746-4e47-ad57-3fb191ca1eed}");
                key.SetValue("AccessDeniedDialog", "{100B4FC8-74C1-470F-B1B7-DD7B6BAE79BD}");
                key.SetValue("DefaultStartViewLayout", "dword:00000002");
                key.SetValue("RPInstalled", "dword:00000000");
                key.SetValue("RPEnabled", "dword:00000000");
                key.SetValue("MIEInstallResult", "dword:00000000");
                key.SetValue("GlobalAssocChangedCounter", "dword:00000002");
                key.Close();*/

            }
            else if (SmartScreen.IsOn)
            {

            }
        }

        private void DiscardApp(object sender, RoutedEventArgs e)
        {
            CheckRegistry();
        }

        private void SettingsApp(object sender, RoutedEventArgs e)
        {
            //TODO
        }
    }
}
