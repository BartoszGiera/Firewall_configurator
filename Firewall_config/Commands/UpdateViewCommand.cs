using Firewall_config.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Firewall_config.Commands
{
    class UpdateViewCommand : ICommand
    {
        private MainWindowViewModel viewModel;

        public UpdateViewCommand(MainWindowViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "Menu")
            {
                viewModel.SelectedViewModel = new MenuViewModel();
            }
            else if (parameter.ToString() == "Question1")
            {
                viewModel.SelectedViewModel = new Question1ViewModel();
            }
            else if (parameter.ToString() == "Question2")
            {
                viewModel.SelectedViewModel = new Question2ViewModel();
            }
            else if (parameter.ToString() == "Question3")
            {
                viewModel.SelectedViewModel = new Question3ViewModel();
            }
            else if (parameter.ToString() == "Question4")
            {
                viewModel.SelectedViewModel = new Question4ViewModel();
            }
            else if (parameter.ToString() == "Question5")
            {
                viewModel.SelectedViewModel = new Question5ViewModel();
            }
            else if (parameter.ToString() == "Question6")
            {
                viewModel.SelectedViewModel = new Question6ViewModel();
            }
            else if (parameter.ToString() == "Question7")
            {
                viewModel.SelectedViewModel = new Question7ViewModel();
            }
            else if (parameter.ToString() == "Question8")
            {
                viewModel.SelectedViewModel = new Question8ViewModel();
            }
            else if (parameter.ToString() == "Configuration")
            {
                viewModel.SelectedViewModel = new ConfigurationViewModel();
            }
        }
    }
}
