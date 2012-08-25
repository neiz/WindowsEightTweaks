using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            progressBar.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            CheckRegistry();
        }

        private void CheckRegistry()
        {
            //This module checks the registry for the status of registry changes;
            //then (re)initializes their radio control
            string[] todo;

            if (DesktopArrows.IsOn)
            {
               
            }
            else if (AutoLogin.IsOn)
            {

            }
            else if (MetroStart.IsOn)
            {

            }
        }

        public Nullable<bool> IsChecked { get; set; }

        private void SendEmail(object sender, RoutedEventArgs e)
        {
            //TODO: Send an Email
        }

        private void SaveApp(object sender, RoutedEventArgs e)
        {
            //TODO
        }

        private void DiscardApp(object sender, RoutedEventArgs e)
        {
            progressBar.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }

        private void SettingsApp(object sender, RoutedEventArgs e)
        {
            //TODO
        }
    }
}
