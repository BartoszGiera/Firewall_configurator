using System;
using System.Collections.Generic;
using System.Text;

namespace Firewall_config.ViewModels
{
    class Question5ViewModel : ViewModelBase
    {
        public static string Rule = "";

        public void SetRule()
        {
            Rule = "-A INPUT -p tcp -s 0.0.0.0/0 --sport 23 -j DROP\n-A OUTPUT -p tcp -d 0.0.0.0/0 --dport 23 -j DROP\n";
        }
    }
}
