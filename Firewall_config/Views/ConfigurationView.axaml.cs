using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Firewall_config.ViewModels;

namespace Firewall_config.Views
{
    public class ConfigurationView : UserControl
    {

        public ConfigurationView()
        {
            this.InitializeComponent();

            DataContext = new ConfigurationViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
