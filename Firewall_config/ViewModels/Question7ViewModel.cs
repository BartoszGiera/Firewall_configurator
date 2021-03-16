using System;
using System.Collections.Generic;
using System.Text;

namespace Firewall_config.ViewModels
{
    class Question7ViewModel : ViewModelBase
    {
        private string _ip;

        public static string Rule = "";

        public string IP
        {
            get { return _ip; }
            set
            {
                _ip = value;
                OnPropertyChanged(nameof(IP));
                System.Diagnostics.Debug.WriteLine(IP);
            }
        }

        public void Zapisz()
        {
            string[] ipAddresses = IP.Split(',');

            foreach (string ip in ipAddresses)
            {
                Rule += $"-A OUTPUT -p all -d {ip} -j DROP\n";
            }

            System.Diagnostics.Debug.WriteLine(Rule);
        }
    }
}
