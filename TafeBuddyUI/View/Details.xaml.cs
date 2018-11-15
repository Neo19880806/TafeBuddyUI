using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TafeBuddyUI.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Details : Page
    {
        public Details()
        {
            this.InitializeComponent();
        }
        public static string Text { get; private set; }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            /* List<Student> myStudent = new List<Student>();

             Student myNewStudent = new Student();
             foreach (var el in myStudent)
             {
                 myStudent.Add(myNewStudent);

             }
 */


            base.OnNavigatedTo(e);
            detailsTextBlock.Text = App.myStudent == null ? "No Student Found" : App.myStudent.ToString();
        }
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }
    }
}
