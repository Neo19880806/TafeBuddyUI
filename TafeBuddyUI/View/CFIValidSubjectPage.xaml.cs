using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CFIProjectUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CFIValidSubjectPage : Page
    {
        public CFIValidSubjectPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            string subject = "ICTPRG301-Apply introductory programming techniques (3PRB)";
            cmbValidSubject.Items.Add(subject);
            if (cmbValidSubject.Items.Count > 0)
            {
                cmbValidSubject.SelectedIndex = 0;
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CFIMainPage),cmbValidSubject.SelectedValue.ToString());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TafeBuddyUI.MainPage));
        }
    }
}
