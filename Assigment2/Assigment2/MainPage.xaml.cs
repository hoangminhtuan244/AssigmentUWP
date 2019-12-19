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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Assigment2
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
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(Pages.Register), new Params() { MyProperty = 42 });
        }
        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            if (Login.IsSelected) { contentFrame.Navigate(typeof(Pages.Login), new Params() { MyProperty = 42 }); }
            else if (Register.IsSelected)
            {
                contentFrame.Navigate(typeof(Pages.Register)); }
            else if (ListSong.IsSelected) { contentFrame.Navigate(typeof(Pages.ListSong)); }
            else if (RegisterSong.IsSelected) { contentFrame.Navigate(typeof(Pages.RegisterSong)); }
        }
    }
    public class Params
    {
        public int MyProperty { get; set; }
    }
}
