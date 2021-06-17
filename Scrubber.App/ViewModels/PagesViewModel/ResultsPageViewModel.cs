using Scrubber.App.Infrastructure.Commands;
using Scrubber.App.ViewModels.Base;
using Scrubber.App.ViewModels.WindowsViewModel;
using Scrubber.App.Views.Windows;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Scrubber.App.ViewModels.PagesViewModel
{

    class ResultsPageViewModel : ViewModel
    {
        private MainWindowViewModel _MainWindowVM;
        public MainWindowViewModel MainWindowVM { get => _MainWindowVM; set => Set(ref _MainWindowVM, value); }

        public СalculationPageViewModel сalculationPageVM;

        private double _EkvDiamCk;
        private double _AktVisotaCk;
        private double _RasstRes;
        private double _RasstRyadRes;
        private double _EnergStep;
        private double _RasPlotRes;
        private double _RasStepRes;
        private double _ChisRyad;
        private double _SkorRes;

        public double EkvDiamCk { get => _EkvDiamCk; set => Set(ref _EkvDiamCk, value); }
        public double AktVisotaCk { get => _AktVisotaCk; set => Set(ref _AktVisotaCk, value); }
        public double RasstRes { get => _RasstRes; set => Set(ref _RasstRes, value); }
        public double RasstRyadRes { get => _RasstRyadRes; set => Set(ref _RasstRyadRes, value); }
        public double EnergStep { get => _EnergStep; set => Set(ref _EnergStep, value); }
        public double RasPlotRes { get => _RasPlotRes; set => Set(ref _RasPlotRes, value); }
        public double RasStepRes { get => _RasStepRes; set => Set(ref _RasStepRes, value); }
        public double ChisRyad { get => _ChisRyad; set => Set(ref _ChisRyad, value); }
        public double SkorRes { get => _SkorRes; set => Set(ref _SkorRes, value); }

        private string _NameResult;
        public string NameResult { get => _NameResult; set => Set(ref _NameResult, value); }
        public ObservableCollection<ResultsPageViewModel> Results { get; set; }

        private ResultsPageViewModel _SelectedResultsItem;
        public ResultsPageViewModel SelectedResultsItem 
        { 
            get => _SelectedResultsItem;
            set
            {
                Set(ref _SelectedResultsItem, value);
                if (SelectedResultsItem != null)
                {
                    EkvDiamCk = SelectedResultsItem.EkvDiamCk;
                    AktVisotaCk = SelectedResultsItem.AktVisotaCk;
                    RasstRes = SelectedResultsItem.RasstRes;
                    RasstRyadRes = SelectedResultsItem.RasstRyadRes;
                    EnergStep = SelectedResultsItem.EnergStep;
                    RasPlotRes = SelectedResultsItem.RasPlotRes;
                    RasStepRes = SelectedResultsItem.RasStepRes;
                    ChisRyad = SelectedResultsItem.ChisRyad;
                    SkorRes = SelectedResultsItem.SkorRes;
                    Results = SelectedResultsItem.Results;
                }
            }
        }
        public ICommand ReportCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if(MainWindowVM.ResultsPageVM.Results.Count != 0 && MainWindowVM.ResultsPageVM.SelectedResultsItem != null)
                    { 
                    MainWindowVM.ReportW = new ReportWindow();
                    MainWindowVM.ReportWindowVM = new ReportWindowViewModel();
                    MainWindowVM.ReportWindowVM.MainWindowVM = MainWindowVM;
                    MainWindowVM.ReportWindowVM.resultsPageVM = MainWindowVM.ResultsPageVM;
                    MainWindowVM.ReportWindowVM.resultsPageVM.сalculationPageVM = MainWindowVM.ResultsPageVM.сalculationPageVM;
                    MainWindowVM.ReportW.DataContext = MainWindowVM.ReportWindowVM;
                    MainWindowVM.ReportW.ShowDialog();
                    }
                });
            }
        }

        public ICommand RemoveResultCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (SelectedResultsItem is ResultsPageViewModel)
                    {
                        Results.Remove(SelectedResultsItem);
                    }
                });
            }
        }

        public ICommand RemoveAllResultCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                        Results.Clear();
                });
            }
        }

        public ResultsPageViewModel()
        {
            Results = new ObservableCollection<ResultsPageViewModel>();
        }
    }
}
