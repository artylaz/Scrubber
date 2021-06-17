using Scrubber.App.Infrastructure.Commands;
using Scrubber.App.ViewModels.Base;
using Scrubber.App.ViewModels.PagesViewModel;
using Scrubber.App.Views.Pages;
using Scrubber.App.Views.Windows;
using Scrubber.MatLibrary;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Scrubber.App.ViewModels.WindowsViewModel
{
    class MainWindowViewModel : ViewModel
    {
        public FScrubber fScrubber;
        public Page TheoryPage { get; set; }
        public Page CalculationPage { get; set; }
        public Page ResultsPage { get; set; }

        public Window NameCalculationW { get; set; }
        public ReportWindow ReportW { get; set; }

        public MainWindowViewModel MainWindowVM { get; set; }
        public ResultsPageViewModel ResultsPageVM { get; set; }
        public TheoryPageViewModel TheoryPageVM { get; set; }
        public СalculationPageViewModel CalculationPageVM { get; set; }

        public NameCalculationWindowViewModel NameCalculationWindowVM { get; set; }
        public ReportWindowViewModel ReportWindowVM { get; set; }

        #region Изменение цвета 
        private string backgroundTheory = "#FF162B1D";
        public string BackgroundTheory
        {
            get => backgroundTheory;
            set => Set(ref backgroundTheory, value);
        }
        private string backgroundCalculat = "#FF162B1D";
        public string BaackgroundCalculat
        {
            get => backgroundCalculat;
            set => Set(ref backgroundCalculat, value);
        }
        private string backgroundResults = "#FF162B1D";
        public string BackgroundResults
        {
            get => backgroundResults;
            set => Set(ref backgroundResults, value);
        }

        #endregion


        private Page _CurrentPage;
        public Page CurrentPage
        {
            get => _CurrentPage;
            set
            {
                Set(ref _CurrentPage, value);
                if(CurrentPage == TheoryPage)
                {
                    BackgroundTheory = "#FF356545";
                    BaackgroundCalculat = "#FF162B1D";
                    BackgroundResults = "#FF162B1D";
                }
                if (CurrentPage == CalculationPage)
                {
                    BackgroundTheory = "#FF162B1D";
                    BaackgroundCalculat = "#FF356545";
                    BackgroundResults = "#FF162B1D";
                }
                if (CurrentPage == ResultsPage)
                {
                    BackgroundTheory = "#FF162B1D";
                    BaackgroundCalculat = "#FF162B1D";
                    BackgroundResults = "#FF356545";
                }
            }
        }

        public MainWindowViewModel()
        {
            fScrubber = new FScrubber();
            
            TheoryPage = new TheoryPage();
            CalculationPage = new СalculationPage();
            ResultsPage = new ResultsPage();

            NameCalculationW = new NameCalculationWindow();
            ReportW = new ReportWindow();

            TheoryPageVM = new TheoryPageViewModel();
            CalculationPageVM = new СalculationPageViewModel();
            ResultsPageVM = new ResultsPageViewModel();

            NameCalculationWindowVM = new NameCalculationWindowViewModel();
            ReportWindowVM = new ReportWindowViewModel();


            //TheoryPageVM.mainWindowVM = this;
            CalculationPageVM.MainWindowVM = this;
            ResultsPageVM.MainWindowVM = this;
            NameCalculationWindowVM.MainWindowVM = this;
            ReportWindowVM.MainWindowVM = this;
            //ResultsPageVM.сalculationPageVM = CalculationPageVM;

            TheoryPage.DataContext = TheoryPageVM;
            CalculationPage.DataContext = CalculationPageVM;
            ResultsPage.DataContext = ResultsPageVM;

            NameCalculationW.DataContext = NameCalculationWindowVM;
            ReportW.DataContext = ReportWindowVM;


            CurrentPage = CalculationPage;

        }

        #region Команды


        public ICommand OpenTheoryPageCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    CurrentPage = TheoryPage;
                });
            }
        }

        public ICommand OpenСalculationPageCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    CurrentPage = CalculationPage;
                });
            }
        }


        public ICommand OpenResultsPageCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    CurrentPage = ResultsPage;
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
