using Scrubber.App.Infrastructure.Commands;
using Scrubber.App.ViewModels.Base;
using Scrubber.App.ViewModels.PagesViewModel;
using System.Windows;
using System.Windows.Input;

namespace Scrubber.App.ViewModels.WindowsViewModel
{
    class NameCalculationWindowViewModel : ViewModel
    {
        private MainWindowViewModel _MainWindowVM;
        public MainWindowViewModel MainWindowVM { get => _MainWindowVM; set => Set(ref _MainWindowVM, value); }

        private string _Name;
        public string Name { get => _Name; set => Set(ref _Name, value); }

        public ICommand SetName
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    bool flag = false;
                    if (Name != null)
                    {
                        if (MainWindowVM.ResultsPageVM.Results.Count != 0)
                            foreach (var item in MainWindowVM.ResultsPageVM.Results)
                            {
                                if (item.NameResult == Name)
                                {
                                    MessageBox.Show("Такое название расчёта уже имеется");
                                    flag = true;
                                    break;
                                }
                            }

                        if (flag != true)
                        {
                            MainWindowVM.ResultsPageVM.Results.Add(new ResultsPageViewModel()
                            {
                                NameResult = Name,
                                EkvDiamCk = MainWindowVM.ResultsPageVM.EkvDiamCk,
                                AktVisotaCk = MainWindowVM.ResultsPageVM.AktVisotaCk,
                                RasstRes = MainWindowVM.ResultsPageVM.RasstRes,
                                RasstRyadRes = MainWindowVM.ResultsPageVM.RasstRyadRes,
                                EnergStep = MainWindowVM.ResultsPageVM.EnergStep,
                                RasPlotRes = MainWindowVM.ResultsPageVM.RasPlotRes,
                                RasStepRes = MainWindowVM.ResultsPageVM.RasStepRes,
                                ChisRyad = MainWindowVM.ResultsPageVM.ChisRyad,
                                SkorRes = MainWindowVM.ResultsPageVM.SkorRes,
                                Results = MainWindowVM.ResultsPageVM.Results,
                                #region
                                сalculationPageVM = new СalculationPageViewModel()
                                {
                                    BarDavlenie = MainWindowVM.CalculationPageVM.BarDavlenie,
                                    IzbitDavlenie = MainWindowVM.CalculationPageVM.IzbitDavlenie,
                                    Rashod = MainWindowVM.CalculationPageVM.Rashod,
                                    TemperGazaVhod = MainWindowVM.CalculationPageVM.TemperGazaVhod,
                                    TemperGazaVihod = MainWindowVM.CalculationPageVM.TemperGazaVihod,
                                    TeploemkVhod = MainWindowVM.CalculationPageVM.TeploemkVhod,
                                    TeploemkVihod = MainWindowVM.CalculationPageVM.TeploemkVihod,
                                    NachVlagosoderg = MainWindowVM.CalculationPageVM.NachVlagosoderg,
                                    PlotnostSuhGaza = MainWindowVM.CalculationPageVM.PlotnostSuhGaza,
                                    PlotnostGidk = MainWindowVM.CalculationPageVM.PlotnostGidk,
                                    DinamVjazkostGaza = MainWindowVM.CalculationPageVM.DinamVjazkostGaza,
                                    TemperVodiVhod = MainWindowVM.CalculationPageVM.TemperVodiVhod,
                                    TeploemkVodi1 = MainWindowVM.CalculationPageVM.TeploemkVodi1,
                                    TeploemkVodi2 = MainWindowVM.CalculationPageVM.TeploemkVodi2,
                                    Poteri = MainWindowVM.CalculationPageVM.Poteri,
                                    TeploemkPara = MainWindowVM.CalculationPageVM.TeploemkPara,
                                    KoefIspar = MainWindowVM.CalculationPageVM.KoefIspar,
                                    DavlenVodi = MainWindowVM.CalculationPageVM.DavlenVodi,
                                    DiametrKapel = MainWindowVM.CalculationPageVM.DiametrKapel,
                                    SrednMedRazmer = MainWindowVM.CalculationPageVM.SrednMedRazmer,
                                    PlotnostChastic = MainWindowVM.CalculationPageVM.PlotnostChastic,
                                    ScorostVihod = MainWindowVM.CalculationPageVM.ScorostVihod,
                                    KoefB = MainWindowVM.CalculationPageVM.KoefB,
                                    KoefE = MainWindowVM.CalculationPageVM.KoefE,
                                    IsCheckedTipCkr = MainWindowVM.CalculationPageVM.IsCheckedTipCkr,
                                    IsCheckedTipRasch = MainWindowVM.CalculationPageVM.IsCheckedTipRasch
                                }
                                #endregion
                            });

                            MainWindowVM.ReportWindowVM.resultsPageVM = MainWindowVM.ResultsPageVM;
                            MainWindowVM.CurrentPage = MainWindowVM.ResultsPage;
                            MainWindowVM.NameCalculationW.Visibility = Visibility.Collapsed;
                        }
                    }

                });
            }
        }

        public ICommand Сancel
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    MainWindowVM.CurrentPage = MainWindowVM.ResultsPage;
                    MainWindowVM.NameCalculationW.Visibility = Visibility.Hidden;
                });
            }
        }

        public ICommand DragMoveCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    MainWindowVM.NameCalculationW.DragMove();
                });
            }
        }

    }
}
