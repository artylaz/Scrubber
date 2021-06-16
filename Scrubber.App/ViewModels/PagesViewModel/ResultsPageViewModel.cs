using Scrubber.App.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Scrubber.App.ViewModels.PagesViewModel
{
    class ResultsPageViewModel : ViewModel
    {
        public Page resultsPage;

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

        public ResultsPageViewModel()
        {
            Results = new ObservableCollection<ResultsPageViewModel>();
        }
    }
}
