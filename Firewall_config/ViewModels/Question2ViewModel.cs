using System;
using System.Collections.Generic;
using System.Text;

namespace Firewall_config.ViewModels
{
    class Question2ViewModel : ViewModelBase
    {
        public static string Rule = "";

        public void SetRule()
        {
            Rule = "-A INPUT -p tcp -s 0.0.0.0/0 --sport 25 -j DROP\n-A INPUT -p udp -s 0.0.0.0/0 --sport 25 -j DROP\n-A OUTPUT -p tcp -d 0.0.0.0/0 --dport 25 -j DROP\n-A OUTPUT -p udp -d 0.0.0.0/0 --dport 25 -j DROP\n" +
                   "-A INPUT -p tcp -s 0.0.0.0/0 --sport 465 -j DROP\n-A INPUT -p udp -s 0.0.0.0/0 --sport 465 -j DROP\n-A OUTPUT -p tcp -d 0.0.0.0/0 --dport 465 -j DROP\n-A OUTPUT -p udp -d 0.0.0.0/0 --dport 465 -j DROP\n" +
                   "-A INPUT -p tcp -s 0.0.0.0/0 --sport 587 -j DROP\n-A INPUT -p udp -s 0.0.0.0/0 --sport 587 -j DROP\n-A OUTPUT -p tcp -d 0.0.0.0/0 --dport 587 -j DROP\n-A OUTPUT -p udp -d 0.0.0.0/0 --dport 587 -j DROP\n";
        }
    }
}
