using Scrubber.App.Infrastructure.Commands;
using Scrubber.App.ViewModels.Base;
using Scrubber.App.ViewModels.WindowsViewModel;
using Scrubber.MatLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;

namespace Scrubber.App.ViewModels.PagesViewModel
{
    class СalculationPageViewModel : ViewModel
    {
        public MainWindowViewModel mainWindowVM;
        public Page resultsPage;
        public ResultsPageViewModel resultsPageVM;
        private FScrubber fScrubber;
        public Dust Dust= new Dust();
        public List<Dust> TipPili { get;set;}
        public СalculationPageViewModel()
        {
            fScrubber = new FScrubber();
            
            TipPili = Dust.TipPili;
            SelectedItemDust = TipPili[0];
        }

        private Dust _SelectedItemDust;
        public Dust SelectedItemDust 
        {
            get => _SelectedItemDust;
            set
            {
                Set(ref _SelectedItemDust, value);
                KoefE = SelectedItemDust.KoefE;
                KoefB = SelectedItemDust.KoefB;
            }
        }

        public ICommand СalculationCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    fScrubber.BarDavlenie = (double)BarDavlenie;
                    fScrubber.IzbitDavlenie = (double)IzbitDavlenie;
                    fScrubber.Rashod = (double)Rashod;
                    fScrubber.TemperaturaGazaVhod = (double)TemperGazaVhod;
                    fScrubber.TemperaturaGazaVihod = (double)TemperGazaVihod;
                    fScrubber.TeploemkGazaVhod = (double)TeploemkVhod;
                    fScrubber.TeploemkGazaVihod = (double)TeploemkVihod;
                    fScrubber.NachVlagosod = (double)NachVlagosoderg;
                    fScrubber.PlotnostSuhGaz = (double)PlotnostSuhGaza;
                    fScrubber.PlotnostOroshGidkosti = (double)PlotnostGidk;
                    fScrubber.DinamVjazkostGaza = (double)DinamVjazkostGaza;
                    fScrubber.TemperVodiVhod = (double)TemperVodiVhod;
                    fScrubber.TeploemkVodi1 = (double)TeploemkVodi1;
                    fScrubber.TeploemkVodi2 = (double)TeploemkVodi2;
                    fScrubber.Poteri = (double)Poteri;
                    fScrubber.TeploemkPara = (double)TeploemkPara;
                    fScrubber.KoefIsparenia = (double)KoefIspar;
                    fScrubber.DavlenieVodi = (double)DavlenVodi;
                    fScrubber.DiametrKapel = (double)DiametrKapel;
                    fScrubber.SrednMedRazmer = (double)SrednMedRazmer;
                    fScrubber.PlotnostPili = (double)PlotnostChastic;
                    fScrubber.ScorostGazaVihod = (double)ScorostVihod;
                    fScrubber.KoefB = (double)KoefB;
                    fScrubber.KoefE = (double)KoefE;

                    if (IsCheckedTipCkr == true)
                        fScrubber.TipScrubbera = 0;
                    else
                        fScrubber.TipScrubbera = 1;

                    if (IsCheckedTipRasch == true)
                        fScrubber.Tiprascheta = 0;
                    else
                        fScrubber.Tiprascheta = 1;

                    resultsPageVM.EkvDiamCk = Math.Round(fScrubber.GetDiametr(), 3);
                    resultsPageVM.AktVisotaCk = Math.Round(fScrubber.GetVisotaScrubber(), 3);
                    resultsPageVM.RasstRes = Math.Round(fScrubber.GetRasstPervRjada(), 3);
                    resultsPageVM.RasstRyadRes = Math.Round(fScrubber.GetRasstMuRjadami(), 3);
                    resultsPageVM.EnergStep = Math.Round(fScrubber.GetStepOchistEnerg(), 5);
                    resultsPageVM.RasPlotRes = Math.Round(fScrubber.GetPloschOroshenia(), 3);
                    resultsPageVM.RasStepRes = Math.Round(fScrubber.GetStepOchistRasch(), 5);
                    resultsPageVM.ChisRyad = Math.Round(fScrubber.GetChisloForsunok(), 0);
                    resultsPageVM.SkorRes = Math.Round(fScrubber.GetScorost(), 3);

                    resultsPage.DataContext = resultsPageVM;
                    mainWindowVM.CurrentPage = resultsPage;
                });
            }
        }

        public bool IsCheckedTipCkr { get; set; } = true;
        public bool IsCheckedTipRasch { get; set; } = true;

        #region Исходные данные

        private int _tipRascheta = 0;
        private int _TipScrubbera = 0;
        private double? _BarDavlenie = 101;
        private double? _IzbitDavlenie = 12;
        private double? _Rashod = 18;
        private double? _TemperGazaVhod = 144;
        private double? _TemperGazaVihod = 49;
        private double? _TeploemkVhod = 0.87;
        private double? _TeploemkVihod = 0.82;
        private double? _NachVlagosoderg = 0.018;
        private double? _PlotnostSuhGaza = 0.95;
        private double? _PlotnostGidk = 1000;
        private double? _DinamVjazkostGaza = 2.2E-05;
        private double? _TemperVodiVhod = 21;
        private double? _TeploemkVodi1 = 4.182;
        private double? _TeploemkVodi2 = 4.182;
        private double? _Poteri = 10;
        private double? _TeploemkPara = 2.09;
        private double? _KoefIspar = 0.5;
        private double? _DavlenVodi = 290;
        private double? _DiametrKapel = 0.008;
        private double? _SrednMedRazmer = 3E-05;
        private double? _PlotnostChastic = 2000;
        private double? _ScorostVihod = 1.8;
        private double? _KoefB = 0.0988;
        private double? _KoefE = 0.4663;

        public int TipRascheta { get => _tipRascheta; set => Set(ref _tipRascheta, value); }
        public int TipScrubbera { get => _TipScrubbera; set => Set(ref _TipScrubbera, value); }
        public double? BarDavlenie { get => _BarDavlenie; set => Set(ref _BarDavlenie, value); }
        public double? IzbitDavlenie { get => _IzbitDavlenie; set => Set(ref _IzbitDavlenie, value); }
        public double? Rashod { get => _Rashod; set => Set(ref _Rashod, value); }
        public double? TemperGazaVhod { get => _TemperGazaVhod; set => Set(ref _TemperGazaVhod, value); }
        public double? TemperGazaVihod { get => _TemperGazaVihod; set => Set(ref _TemperGazaVihod, value); }
        public double? TeploemkVhod { get => _TeploemkVhod; set => Set(ref _TeploemkVhod, value); }
        public double? TeploemkVihod { get => _TeploemkVihod; set => Set(ref _TeploemkVihod, value); }
        public double? NachVlagosoderg { get => _NachVlagosoderg; set => Set(ref _NachVlagosoderg, value); }
        public double? PlotnostSuhGaza { get => _PlotnostSuhGaza; set => Set(ref _PlotnostSuhGaza, value); }
        public double? PlotnostGidk { get => _PlotnostGidk; set => Set(ref _PlotnostGidk, value); }
        public double? DinamVjazkostGaza { get => _DinamVjazkostGaza; set => Set(ref _DinamVjazkostGaza, value); }
        public double? TemperVodiVhod { get => _TemperVodiVhod; set => Set(ref _TemperVodiVhod, value); }
        public double? TeploemkVodi1 { get => _TeploemkVodi1; set => Set(ref _TeploemkVodi1, value); }
        public double? TeploemkVodi2 { get => _TeploemkVodi2; set => Set(ref _TeploemkVodi2, value); }
        public double? Poteri { get => _Poteri; set => Set(ref _Poteri, value); }
        public double? TeploemkPara { get => _TeploemkPara; set => Set(ref _TeploemkPara, value); }
        public double? KoefIspar { get => _KoefIspar; set => Set(ref _KoefIspar, value); }
        public double? DavlenVodi { get => _DavlenVodi; set => Set(ref _DavlenVodi, value); }
        public double? DiametrKapel { get => _DiametrKapel; set => Set(ref _DiametrKapel, value); }
        public double? SrednMedRazmer { get => _SrednMedRazmer; set => Set(ref _SrednMedRazmer, value); }
        public double? PlotnostChastic { get => _PlotnostChastic; set => Set(ref _PlotnostChastic, value); }
        public double? ScorostVihod { get => _ScorostVihod; set => Set(ref _ScorostVihod, value); }
        public double? KoefB { get => _KoefB; set => Set(ref _KoefB, value); }
        public double? KoefE { get => _KoefE; set => Set(ref _KoefE, value); }
        #endregion
    }
}
