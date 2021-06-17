using FastReport;
using FastReport.Export.Image;
using FastReport.Export.PdfSimple;
using Scrubber.App.Infrastructure.Commands;
using Scrubber.App.Models.Report;
using Scrubber.App.ViewModels.Base;
using Scrubber.App.ViewModels.PagesViewModel;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Scrubber.App.ViewModels.WindowsViewModel
{
    class ReportWindowViewModel : ViewModel
    {
        private MainWindowViewModel _MainWindowVM;
        public MainWindowViewModel MainWindowVM { get => _MainWindowVM; set => Set(ref _MainWindowVM, value); }

        public ResultsPageViewModel resultsPageVM;
        private List<Category> Categories;

        private ImageSource _ImagePreview;
        public ImageSource ImagePreview { get => _ImagePreview; set => Set(ref _ImagePreview, value); }

        //private Uri _WebViewerUri;
        //public Uri WebViewerUri { get => _WebViewerUri; set => Set(ref _WebViewerUri, value); }

        private List<Result> Results;

        private string inFolder = @"..\..\..\in\";
        public ReportWindowViewModel()
        {
            inFolder = Utils.FindDirectory("in");
        }

        public ICommand GenerateReportCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if(resultsPageVM.Results != null)
                    foreach (var item in resultsPageVM.Results)
                    {
                        if (item.NameResult == resultsPageVM.SelectedResultsItem.NameResult)
                            resultsPageVM.SelectedResultsItem.NameResult += "1";
                    }

                    CreateBusinessObject();

                    Report report = new Report();

                    report.Load($@"{inFolder}\report.frx");

                    report.RegisterData(Categories, "Categories");
                    report.RegisterData(Results, "Results");

                    report.Prepare();

                    report.SavePrepared("Prepared_Report.fpx");

                    ImageExport image = new ImageExport();
                    image.ImageFormat = ImageExportFormat.Jpeg;


                    report.Export(image, $"report{resultsPageVM.SelectedResultsItem.NameResult}.jpg");


                    #region -- Export to PDF

                    PDFSimpleExport pdfExport = new PDFSimpleExport();

                    pdfExport.Export(report, $"report{resultsPageVM.SelectedResultsItem.NameResult}.pdf");

                    #endregion


                    report.Dispose();
                    //------------------------

                    ImagePreview = null;

                    var uriImageSource = new Uri(AppDomain.CurrentDomain.BaseDirectory + $@"report{resultsPageVM.SelectedResultsItem.NameResult}.jpg", UriKind.RelativeOrAbsolute);
                    ImagePreview = new BitmapImage(uriImageSource);

                });
            }
        }

        public ICommand GenerateReporPDFCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    var uri = new Uri(AppDomain.CurrentDomain.BaseDirectory + $"report{resultsPageVM.SelectedResultsItem.NameResult}.pdf");
                    MainWindowVM.ReportW.webViewer.Source = uri;
                });
            }
        }



        private void CreateBusinessObject()
        {
            Results = new List<Result>()
            {
                new Result { Name = "Начальное влагосодержание газа, кг/м³", UnitResult = resultsPageVM.SelectedResultsItem.сalculationPageVM.NachVlagosoderg}
            };

            Categories = new List<Category>();

            Category category = new Category("Исходные данные", "Данные введенные пользователем");

            category.Results.Add(new Result("Барометрическое давление на местности, кПа", resultsPageVM.SelectedResultsItem.сalculationPageVM.BarDavlenie));
            category.Results.Add(new Result("Избыточное давление (разрежение) газа, кПа", resultsPageVM.SelectedResultsItem.сalculationPageVM.IzbitDavlenie));
            category.Results.Add(new Result("Расход сухого газа на очистку, м³/с", resultsPageVM.SelectedResultsItem.сalculationPageVM.Rashod));
            category.Results.Add(new Result("Температура газа на входе в скруббер, °С", resultsPageVM.SelectedResultsItem.сalculationPageVM.TemperGazaVhod));
            category.Results.Add(new Result("Температура газа на выходе из скруббера, °С", resultsPageVM.SelectedResultsItem.сalculationPageVM.TemperGazaVihod));
            category.Results.Add(new Result("Теплоемкость газа для условий входа, кДж/(м² град)", resultsPageVM.SelectedResultsItem.сalculationPageVM.TeploemkVhod));
            category.Results.Add(new Result("Теплоемкость газа для условий выхода, кДж/(м² град)", resultsPageVM.SelectedResultsItem.сalculationPageVM.TeploemkVihod));
            category.Results.Add(new Result("Начальное влагосодержание газа, кг/м³", resultsPageVM.SelectedResultsItem.сalculationPageVM.NachVlagosoderg));
            category.Results.Add(new Result("Плотность сухого газа, кг/м³", resultsPageVM.SelectedResultsItem.сalculationPageVM.PlotnostSuhGaza));
            category.Results.Add(new Result("Плотность орошающей жидкости, кг/м³", resultsPageVM.SelectedResultsItem.сalculationPageVM.PlotnostGidk));
            category.Results.Add(new Result("Динамическая вязкость газа, Па с", resultsPageVM.SelectedResultsItem.сalculationPageVM.DinamVjazkostGaza));
            category.Results.Add(new Result("Температура воды, подаваемой на орошение, °С", resultsPageVM.SelectedResultsItem.сalculationPageVM.TemperVodiVhod));
            category.Results.Add(new Result("Теплоемкость воды от 0 до tж'', кДж/кг", resultsPageVM.SelectedResultsItem.сalculationPageVM.TeploemkVodi1));
            category.Results.Add(new Result("Теплоемкость воды от tж' до tж'', кДж/кг", resultsPageVM.SelectedResultsItem.сalculationPageVM.TeploemkVodi2));
            category.Results.Add(new Result("Тепловые потери скруббера, %", resultsPageVM.SelectedResultsItem.сalculationPageVM.Poteri));
            category.Results.Add(new Result("Теплоемкость насыщенного водяного пара, кДж/(кг К)", resultsPageVM.SelectedResultsItem.сalculationPageVM.TeploemkPara));
            category.Results.Add(new Result("Коэффициент испарения воды", resultsPageVM.SelectedResultsItem.сalculationPageVM.KoefIspar));
            category.Results.Add(new Result("Давление воды перед форсункой, кПа", resultsPageVM.SelectedResultsItem.сalculationPageVM.DavlenVodi));
            category.Results.Add(new Result("Диаметр капель, м", resultsPageVM.SelectedResultsItem.сalculationPageVM.DiametrKapel));
            category.Results.Add(new Result("Средний медианный размер пыли, м", resultsPageVM.SelectedResultsItem.сalculationPageVM.SrednMedRazmer));
            category.Results.Add(new Result("Плотность пылевых частиц, кг/м³", resultsPageVM.SelectedResultsItem.сalculationPageVM.PlotnostChastic));
            category.Results.Add(new Result("Скорость газа на выходе из скруббера, м/с", resultsPageVM.SelectedResultsItem.сalculationPageVM.ScorostVihod));
            category.Results.Add(new Result("Температура очистки газа, °C", resultsPageVM.SelectedResultsItem.сalculationPageVM.KoefB));
            category.Results.Add(new Result("Температура очистки газа, °C", resultsPageVM.SelectedResultsItem.сalculationPageVM.KoefE));
            Categories.Add(category);

            category = new Category("Расчёты", "Данные, полученные по итогам работы программы");
            category.Results.Add(new Result("Эквивалентный диаметр скруббера, м", resultsPageVM.SelectedResultsItem.EkvDiamCk));
            category.Results.Add(new Result("Активная высота скруббера, м", resultsPageVM.SelectedResultsItem.AktVisotaCk));
            category.Results.Add(new Result("Расстояние между осью подвода газа и первым рядом форсунок, м", resultsPageVM.SelectedResultsItem.RasstRes));
            category.Results.Add(new Result("Расстояние между рядами форсунок, м", resultsPageVM.SelectedResultsItem.RasstRyadRes));
            category.Results.Add(new Result("Энергетический коэффициент степени очистки", resultsPageVM.SelectedResultsItem.EnergStep));
            category.Results.Add(new Result("Расчетная плотность орошения газа", resultsPageVM.SelectedResultsItem.RasPlotRes));
            category.Results.Add(new Result("Расчетная степень очистки", resultsPageVM.SelectedResultsItem.RasStepRes));
            category.Results.Add(new Result("Число рядов форсунок", resultsPageVM.SelectedResultsItem.ChisRyad));
            category.Results.Add(new Result("Расчетная скорость газа в скруббере, м/с", resultsPageVM.SelectedResultsItem.SkorRes));
            Categories.Add(category);
        }
    }
}
