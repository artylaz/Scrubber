using Scrubber.App.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrubber.App.ViewModels.PagesViewModel
{
    class ResultsPageViewModel : ViewModel
    {
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


    }
}
