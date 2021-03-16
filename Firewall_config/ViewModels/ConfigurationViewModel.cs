using System;
using System.Collections.Generic;
using System.Text;
using Avalonia.Controls;
using Firewall_config.Views;
using Firewall_config.Commands;
using System.Linq;

namespace Firewall_config.ViewModels
{
    class ConfigurationViewModel : ViewModelBase
    {

        private string _sourceIP;

        public string SourceIP
        {
            get { return _sourceIP; }
            set
            {
                _sourceIP = value;
                OnPropertyChanged(nameof(SourceIP));
            }
        }

        private string _sourcePort;

        public string SourcePort
        {
            get { return _sourcePort; }
            set
            {
                _sourcePort = value;
                OnPropertyChanged(nameof(SourcePort));
            }
        }

        private string _destinationIP;

        public string DestinationIP
        {
            get { return _destinationIP; }
            set
            {
                _destinationIP = value;
                OnPropertyChanged(nameof(DestinationIP));
            }
        }

        private string _destinationPort;

        public string DestinationPort
        {
            get { return _destinationPort; }
            set
            {
                _destinationPort = value;
                OnPropertyChanged(nameof(DestinationPort));
            }
        }

        private ComboBoxItem _ruleChain;

        public ComboBoxItem RuleChain
        {
            get { return _ruleChain; }
            set
            {
                _ruleChain = value;
                OnPropertyChanged(nameof(RuleChain));
            }
        }

        private ComboBoxItem _protocol;

        public ComboBoxItem Protocol
        {
            get { return _protocol; }
            set
            {
                _protocol = value;
                OnPropertyChanged(nameof(Protocol));
                if (Protocol.Content.ToString() == "icmp" || Protocol.Content.ToString() == "all")
                {
                    IsPortEnabled = false;
                }
                else
                {
                    IsPortEnabled = true;
                }
            }
        }

        private ComboBoxItem _action;

        public ComboBoxItem Action
        {
            get { return _action; }
            set
            {
                _action = value;
                OnPropertyChanged(nameof(Action));
            }
        }

        private bool _isPortEnabled;

        public bool IsPortEnabled
        {
            get { return _isPortEnabled; }
            set
            {
                _isPortEnabled = value;
                OnPropertyChanged(nameof(IsPortEnabled));
            }
        }



        private string _allrules = 
            Question8ViewModel.Rule +
            Question7ViewModel.Rule +
            Question6ViewModel.Rule +
            Question5ViewModel.Rule +
            Question4ViewModel.Rule +
            Question3ViewModel.Rule +
            Question2ViewModel.Rule +
            Question1ViewModel.Rule +
            "-P INPUT ACCEPT\n-P FORWARD ACCEPT\n-P OUTPUT ACCEPT";

        public string AllRules
        {
            get { return _allrules; }
            set
            {
                _allrules = value;
                OnPropertyChanged(nameof(AllRules));
            }
        }


        public string AddRule()
        {
            string result;

            if (Protocol.Content.ToString() == "icmp" || Protocol.Content.ToString() == "all")
            {
                result = $"-A {RuleChain.Content.ToString()} -p {Protocol.Content.ToString()}";

                if (Protocol.Content.ToString() == "icmp")
                {
                    result += " --icmp-type any";
                }
                if (SourcePort != "")
                {
                    result += $" -s {SourceIP}";
                }
                if (DestinationIP != "")
                {
                    result += $" -d {DestinationIP}";
                }
            }
            else
            {
                result = $"-A {RuleChain.Content.ToString()} -p {Protocol.Content.ToString()}";

                if (SourceIP != "")
                {
                    result += $" -s {SourceIP}";
                }
                if (SourcePort != "")
                {
                    result += $" --sport {SourcePort}";
                }
                if (DestinationIP != "")
                {
                    result += $" -d {DestinationIP}";
                }
                if (DestinationPort != "")
                {
                    result += $" --dport {DestinationPort}";
                }
            }
           
            result += $" -j {Action.Content.ToString()}";

            AllRules = result + "\n" + AllRules;
            return result;
        }



        public void Zapisz()
        {
            string[] reversedRules = AllRules.Split('\n');

            "iptables --flush".Bash();

            for (int i = reversedRules.Length - 1; i >= 0; i--)
            {
                reversedRules[i] = "iptables " + reversedRules[i];

                reversedRules[i].Bash();
            }
        }
    }
}
