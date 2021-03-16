using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Firewall_config.ViewModels;

namespace Firewall_config.Views
{
    public class Question6View : UserControl
    {
        private Button zapiszButton;

        public Question6View()
        {
            this.InitializeComponent();

            DataContext = new Question6ViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            zapiszButton = this.FindControl<Button>("zapiszButton");
        }

        public void Click_Zapisz(object sender, RoutedEventArgs e)
        {
            zapiszButton.IsEnabled = false;
        }
    }
}
