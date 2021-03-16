using Avalonia.Interactivity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Firewall_config.ViewModels
{
    class Question1ViewModel : ViewModelBase
    {
        public static string Rule = "";

        public void SetRule()
        {
            Rule = "-A INPUT -p tcp -s 0.0.0.0/0 --sport 80 -j DROP\n-A INPUT -p udp -s 0.0.0.0/0 --sport 80 -j DROP\n-A OUTPUT -p tcp -d 0.0.0.0/0 --dport 80 -j DROP\n-A OUTPUT -p udp -d 0.0.0.0/0 --dport 80 -j DROP\n" +
                   "-A INPUT -p tcp -s 0.0.0.0/0 --sport 8080 -j DROP\n-A INPUT -p udp -s 0.0.0.0/0 --sport 8080 -j DROP\n-A OUTPUT -p tcp -d 0.0.0.0/0 --dport 8080 -j DROP\n-A OUTPUT -p udp -d 0.0.0.0/0 --dport 8080 -j DROP\n";
        }
    }
}
