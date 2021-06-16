using Scrubber.App.Infrastructure.Commands;
using Scrubber.App.ViewModels.Base;
using Scrubber.App.ViewModels.PagesViewModel;
using Scrubber.App.Views.Windows;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Scrubber.App.ViewModels.WindowsViewModel
{
    class NameCalculationWindowViewModel : ViewModel
    {
        public ResultsPageViewModel resultsPageVM;
        public NameCalculationWindow nameCalW;
        public Page resultsPage;
        public MainWindowViewModel mainWindowVM;

        private string _Name;
        public string Name { get => _Name; set => Set(ref _Name, value); }

        public ICommand SetName
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    resultsPageVM.Results.Add(new ResultsPageViewModel()
                    {
                        NameResult = Name,
                        EkvDiamCk = resultsPageVM.EkvDiamCk,
                        AktVisotaCk = resultsPageVM.AktVisotaCk,
                        RasstRes = resultsPageVM.RasstRes,
                        RasstRyadRes = resultsPageVM.RasstRyadRes,
                        EnergStep = resultsPageVM.EnergStep,
                        RasPlotRes = resultsPageVM.RasPlotRes,
                        RasStepRes = resultsPageVM.RasStepRes,
                        ChisRyad = resultsPageVM.ChisRyad,
                        SkorRes = resultsPageVM.SkorRes,
                        Results = resultsPageVM.Results
                    });
                    mainWindowVM.CurrentPage = resultsPage;
                    nameCalW.Close();
                });
            }
        }

        public ICommand Сancel
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    mainWindowVM.CurrentPage = resultsPage;
                    nameCalW.Close();
                });
            }
        }

        public ICommand DragMoveCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    nameCalW.DragMove();
                });
            }
        }

    }
}
