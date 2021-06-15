using Scrubber.App.Infrastructure.Commands;
using Scrubber.App.ViewModels.Base;
using Scrubber.App.ViewModels.PagesViewModel;
using Scrubber.App.Views.Pages;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Scrubber.App.ViewModels.WindowsViewModel
{
    class MainWindowViewModel : ViewModel
    {
        private readonly Page theoryPage;
        private readonly Page calculationPage;
        private readonly Page resultsPage;

        private ResultsPageViewModel resultsPageVM;
        private TheoryPageViewModel theoryPageVM;
        private СalculationPageViewModel calculationPageVM;

        private Page _CurrentPage;
        public Page CurrentPage
        {
            get => _CurrentPage;
            set => Set(ref _CurrentPage, value);
        }

        public MainWindowViewModel()
        {
            resultsPageVM = new ResultsPageViewModel();
            theoryPageVM = new TheoryPageViewModel();
            calculationPageVM = new СalculationPageViewModel();
            
            theoryPage = new TheoryPage();
            theoryPage.DataContext = theoryPageVM;

            calculationPage = new СalculationPage();
            calculationPage.DataContext = calculationPageVM;

            resultsPage = new ResultsPage();
            resultsPage.DataContext = resultsPageVM;

            calculationPageVM.resultsPageVM = resultsPageVM;
            calculationPageVM.resultsPage = resultsPage;

            CurrentPage = calculationPage;


            calculationPageVM.mainWindowVM = this;
        }

        #region Команды


        public ICommand OpenTheoryPageCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    CurrentPage = theoryPage;
                });
            }
        }

        public ICommand OpenСalculationPageCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    CurrentPage = calculationPage;
                });
            }
        }


        public ICommand OpenResultsPageCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    resultsPage.DataContext = resultsPageVM;
                    CurrentPage = resultsPage;
                });
            }
        }

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
        #endregion
    }
}
