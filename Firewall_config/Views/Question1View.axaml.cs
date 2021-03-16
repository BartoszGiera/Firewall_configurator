using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Firewall_config.ViewModels;
using Firewall_config.Views;

namespace Firewall_config.Views
{
    public class Question1View : UserControl
    {
        private Button takButton;
        private Button nieButton;

        public Question1View()
        {
            this.InitializeComponent();

            DataContext = new Question1ViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            takButton = this.FindControl<Button>("takButton");
            nieButton = this.FindControl<Button>("nieButton");

        }

        public void Click_Tak(object sender, RoutedEventArgs e)
        {
            takButton.IsEnabled = false;
            nieButton.IsEnabled = true;
        }


        public void Click_Nie(object sender, RoutedEventArgs e)
        {
            takButton.IsEnabled = true;
            nieButton.IsEnabled = false;
        }

    }
}
