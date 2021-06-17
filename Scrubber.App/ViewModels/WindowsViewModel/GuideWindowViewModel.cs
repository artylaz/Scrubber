using Scrubber.App.Infrastructure.Commands;
using Scrubber.App.ViewModels.Base;
using System.Windows.Input;

namespace Scrubber.App.ViewModels.WindowsViewModel
{
    class GuideWindowViewModel : ViewModel
    {
        private MainWindowViewModel _MainWindowVM;
        public MainWindowViewModel MainWindowVM { get => _MainWindowVM; set => Set(ref _MainWindowVM, value); }
        public ICommand DragMoveCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    MainWindowVM.GuideW.DragMove();
                });
            }
        }

        public ICommand CloseCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    MainWindowVM.GuideW.Close();
                });
            }
        }
    }
}
