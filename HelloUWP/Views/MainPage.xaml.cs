using System;

using HelloUWP.ViewModels;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace HelloUWP.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var myDialog = new MessageDialog("안녕하세용");
            myDialog.Commands.Add(new UICommand("OK"));
            myDialog.Commands.Add(new UICommand("CANCEL"));
            myDialog.Commands.Add(new UICommand("BYE"));
            await myDialog.ShowAsync();
        }
    }
}
