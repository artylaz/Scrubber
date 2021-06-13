using Scrubber.App.Infrastructure.Commands;
using Scrubber.App.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace Scrubber.App.ViewModels.WindowsViewModel
{
    class MainWindowViewModel : ViewModel
    {
        public ICommand DragMoveCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    Application.Current.MainWindow.DragMove();
                });
            }
        }

        public ICommand CloseAppCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    Application.Current.Shutdown();
                });
            }
        }
    }
}
