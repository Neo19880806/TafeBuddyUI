using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TafeBuddyUI.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;
using TafeBuddyUI;
using TafeBuddyUI.View;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace studyPlan
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SPMainPage : Page
    {
        Student myStudent = new Student();
        public SPMainPage()
        {
            this.InitializeComponent();
        }

        private void studyPlanButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TafeBuddyUI.MainPage));
        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                var MessageDialog = new MessageDialog("Enter ur name");
                await MessageDialog.ShowAsync();
                return;
            }
            else
                if (idTextBox.Text == "")
            {
                var MessageDialog = new MessageDialog("Enter ur id ");
                await MessageDialog.ShowAsync();
                return;
            }
            else
                if (emailTextBox.Text == "")
            {
                var MessageDialog = new MessageDialog("Enter ur email");
                await MessageDialog.ShowAsync();
                return;
            }
            else if (phoneTextBox.Text == "")
            {
                var MessageDialog = new MessageDialog("Enter ur phone number");
                await MessageDialog.ShowAsync();
                return;
            }

            else
            {
                Student s = new Student();
                s.Name = nameTextBox.Text;
                s.ID = idTextBox.Text;
                s.Phone = phoneTextBox.Text;
                s.Email = emailTextBox.Text;

                App.myStudent = s;
                Frame.Navigate(typeof(Details));
            }
        }
    }
}
