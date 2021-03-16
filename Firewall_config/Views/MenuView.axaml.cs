using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Firewall_config.ViewModels;

namespace Firewall_config.Views
{
    public class MenuView : UserControl
    {
        public MenuView()
        {
            this.InitializeComponent();


        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
