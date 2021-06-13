using System;

namespace Scrubber.MatLibrary
{
    public class FScrubber
    {
        private int _tipRascheta;
        private int _TipScrubbera;
        private double _BarDavlenie;
        private double _IzbitDavlenie;
        private double _Rashod;
        private double _TemperGazaVhod;
        private double _TemperGazaVihod;
        private double _TeploemkVhod;
        private double _TeploemkVihod;
        private double _NachVlagosoderg;
        private double _PlotnostSuhGaza;
        private double _PlotnostGidk;
        private double _DinamVjazkostGaza;
        private double _TemperVodiVhod;
        private double _TeploemkVodi1;
        private double _TeploemkVodi2;
        private double _Poteri;
        private double _TeploemkPara;
        private double _KoefIspar;
        private double _DavlenVodi;
        private double _DiametrKapel;
        private double _SrednMedRazmer;
        private double _PlotnostChastic;
        private double _ScorostVihod;
        private double _KoefB;
        private double _KoefE;
        private double _Keningem;
        private double _SoprotScrubbera;
        private string _sProperty;
        private string _sFileName;

        public string Property
        {
            get => this._sProperty;
            set => this._sProperty = value != null ? value : throw new ArgumentException("Не определен объект Property");
        }

        public string FileName
        {
            get => this._sFileName;
            set => this._sFileName = value != null && value.Length != 0 ? value : throw new ArgumentException("Не определен объект FileName");
        }

        public int Tiprascheta
        {
            get => this._tipRascheta;
            set
            {
                if (value < 0 || value > 1)
                    throw new ArgumentException("Ошибка ввода типа расчета", "TipScrubbera");
                if (this._tipRascheta == value)
                    return;
                this._tipRascheta = value;
            }
        }

        public int TipScrubbera
        {
            get => this._TipScrubbera;
            set
            {
                if (value < 0 || value > 1)
                    throw new ArgumentException("Ошибка ввода типа скруббера", nameof(TipScrubbera));
                if (this._TipScrubbera == value)
                    return;
                this._TipScrubbera = value;
            }
        }

        public double BarDavlenie
        {
            get => this._BarDavlenie;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода барометрического давления", nameof(BarDavlenie));
                if (this._BarDavlenie == value)
                    return;
                this._BarDavlenie = value;
            }
        }

        public double IzbitDavlenie
        {
            get => this._IzbitDavlenie;
            set
            {
                if (value <= -30.0 || value >= 30.0)
                    throw new ArgumentException("Ошибка ввода избыточного давления", nameof(IzbitDavlenie));
                if (this._IzbitDavlenie == value)
                    return;
                this._IzbitDavlenie = value;
            }
        }

        public double Rashod
        {
            get => this._Rashod;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода расхода сухого газа", nameof(Rashod));
                if (this._Rashod == value)
                    return;
                this._Rashod = value;
            }
        }

        public double TemperaturaGazaVhod
        {
            get => this._TemperGazaVhod;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода температуры газа на входе", nameof(TemperaturaGazaVhod));
                if (this._TemperGazaVhod == value)
                    return;
                this._TemperGazaVhod = value;
            }
        }

        public double TemperaturaGazaVihod
        {
            get => this._TemperGazaVihod;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода температуры газа на выходе", nameof(TemperaturaGazaVihod));
                if (this._TemperGazaVihod == value)
                    return;
                this._TemperGazaVihod = value;
            }
        }

        public double TeploemkGazaVhod
        {
            get => this._TeploemkVhod;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода теплоекости газа на входе", nameof(TeploemkGazaVhod));
                if (this._TeploemkVhod == value)
                    return;
                this._TeploemkVhod = value;
            }
        }

        public double TeploemkGazaVihod
        {
            get => this._TeploemkVihod;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода теплоекости газа на выходе", nameof(TeploemkGazaVihod));
                if (this._TeploemkVihod == value)
                    return;
                this._TeploemkVihod = value;
            }
        }

        public double NachVlagosod
        {
            get => this._NachVlagosoderg;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода начального влагосодержания", nameof(NachVlagosod));
                if (this._NachVlagosoderg == value)
                    return;
                this._NachVlagosoderg = value;
            }
        }

        public double PlotnostSuhGaz
        {
            get => this._PlotnostSuhGaza;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода плотности сухого газа", nameof(PlotnostSuhGaz));
                if (this._PlotnostSuhGaza == value)
                    return;
                this._PlotnostSuhGaza = value;
            }
        }

        public double PlotnostOroshGidkosti
        {
            get => this._PlotnostGidk;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода плотности орошаемой жидкости", nameof(PlotnostOroshGidkosti));
                if (this._PlotnostGidk == value)
                    return;
                this._PlotnostGidk = value;
            }
        }

        public double DinamVjazkostGaza
        {
            get => this._DinamVjazkostGaza;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода динамической вязкости газа", nameof(DinamVjazkostGaza));
                if (this._DinamVjazkostGaza == value)
                    return;
                this._DinamVjazkostGaza = value;
            }
        }

        public double TemperVodiVhod
        {
            get => this._TemperVodiVhod;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода температуры воды на орошение", "DinamVjazkostGaza");
                if (this._TemperVodiVhod == value)
                    return;
                this._TemperVodiVhod = value;
            }
        }

        public double TeploemkVodi1
        {
            get => this._TeploemkVodi1;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода теплоемкости воды", nameof(TeploemkVodi1));
                if (this._TeploemkVodi1 == value)
                    return;
                this._TeploemkVodi1 = value;
            }
        }

        public double TeploemkVodi2
        {
            get => this._TeploemkVodi1;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода теплоемкости воды", nameof(TeploemkVodi2));
                if (this._TeploemkVodi2 == value)
                    return;
                this._TeploemkVodi2 = value;
            }
        }

        public double Poteri
        {
            get => this._Poteri;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода тепловых потерь", nameof(Poteri));
                if (this._Poteri == value)
                    return;
                this._Poteri = value;
            }
        }

        public double TeploemkPara
        {
            get => this._TeploemkPara;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода теплоемкости пара", nameof(TeploemkPara));
                if (this._TeploemkPara == value)
                    return;
                this._TeploemkPara = value;
            }
        }

        public double KoefIsparenia
        {
            get => this._KoefIspar;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода коэффициента испарения", nameof(KoefIsparenia));
                if (this._KoefIspar == value)
                    return;
                this._KoefIspar = value;
            }
        }

        public double DavlenieVodi
        {
            get => this._DavlenVodi;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода давления воды перед форсункой", nameof(DavlenieVodi));
                if (this._DavlenVodi == value)
                    return;
                this._DavlenVodi = value;
            }
        }

        public double DiametrKapel
        {
            get => this._DiametrKapel;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода диаметра капель", nameof(DiametrKapel));
                if (this._DiametrKapel == value)
                    return;
                this._DiametrKapel = value;
            }
        }

        public double SrednMedRazmer
        {
            get => this._SrednMedRazmer;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода среднего медианного размера", nameof(SrednMedRazmer));
                if (this._SrednMedRazmer == value)
                    return;
                this._SrednMedRazmer = value;
            }
        }

        public double PlotnostPili
        {
            get => this._PlotnostChastic;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода плотности частиц пили", nameof(PlotnostPili));
                if (this._PlotnostChastic == value)
                    return;
                this._PlotnostChastic = value;
            }
        }

        public double ScorostGazaVihod
        {
            get => this._ScorostVihod;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода скорости газа на выходе", nameof(ScorostGazaVihod));
                if (this._ScorostVihod == value)
                    return;
                this._ScorostVihod = value;
            }
        }

        public double KoefB
        {
            get => this._KoefB;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода коэффициента B", nameof(KoefB));
                if (this._KoefB == value)
                    return;
                this._KoefB = value;
            }
        }

        public double KoefE
        {
            get => this._KoefE;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода коэффициента E", nameof(KoefE));
                if (this._KoefE == value)
                    return;
                this._KoefE = value;
            }
        }

        public double Keningem
        {
            get => this._Keningem;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода поправки Кенингема-Милликена", nameof(Keningem));
                if (this._Keningem == value)
                    return;
                this._Keningem = value;
            }
        }

        public double SoprotScrub
        {
            get => this._SoprotScrubbera;
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("Ошибка ввода сопротивления скруббера", nameof(SoprotScrub));
                if (this._SoprotScrubbera == value)
                    return;
                this._SoprotScrubbera = value;
            }
        }

        public double GetTeplosodergParov1() => 2480.0 + 1.96 * this.TemperaturaGazaVhod;

        public double GetTeplosodergParov2() => 2480.0 + 1.96 * this.TemperaturaGazaVihod;

        public double GetTemperVodiVihod() => 9.568 * Math.Pow(this.NachVlagosod * 1000.0, 0.658) * Math.Pow(this.TemperaturaGazaVhod, 0.058 * Math.Pow(this.NachVlagosod * 1000.0, -0.48)) - 7.0;

        public double GetTeplosodGazaVhod() => this.TeploemkGazaVhod * this.TemperaturaGazaVhod + this.NachVlagosod * (this.GetTeplosodergParov1() - this.GetTeplosodergParov2());

        public double GetTeplosodGazaVihod() => this.TeploemkGazaVihod * this.TemperaturaGazaVihod;

        public double GetKolTepla()
        {
            double num = 1.0 + 0.01 * this.Poteri;
            if (num == 0.0)
                throw new ArgumentException("Ошибка расчета количества тепла");
            return this.Rashod * (this.GetTeplosodGazaVhod() - this.GetTeplosodGazaVihod()) / num;
        }

        public double GetRashodVodi()
        {
            double num1 = this.TeploemkPara * this.GetTemperVodiVihod();
            double num2 = this.TeploemkVodi1 * this.TemperVodiVhod;
            double num3 = this.TeploemkVodi2 * this.GetTemperVodiVihod();
            double num4 = this.PlotnostOroshGidkosti / 1000.0 * (this.KoefIsparenia * (num1 - num2) + (1.0 - this.KoefIsparenia) * (num3 - num2));
            if (num4 == 0.0)
                throw new ArgumentException("Ошибка расчета расхода воды");
            return this.GetKolTepla() / num4;
        }

        public double GetVlagosodergKonech()
        {
            if (this.Rashod == 0.0)
                throw new ArgumentException("Ошибка расчета конечного влагосодержания пара");
            return this.NachVlagosod + this.KoefIsparenia * this.GetRashodVodi() / this.Rashod;
        }

        public double GetObjemRashod()
        {
            double num = this.BarDavlenie + this.IzbitDavlenie;
            if (num == 0.0)
                throw new ArgumentException("Ошибка расчета объемного расхода газа на выходе");
            return this.Rashod * (1.0 + this.GetVlagosodergKonech() / 0.804) * (1.0 + this.TemperaturaGazaVihod / 273.0) * 101.3 / num;
        }

        public double GetObjemScrubbera()
        {
            double num1 = this.Rashod * this.PlotnostSuhGaz;
            if (num1 == 0.0)
                throw new ArgumentException("Ошибка расчета объема скруббера");

            return (1.0 + 0.001 * (this.TemperaturaGazaVhod + this.TemperaturaGazaVihod) / 2.0) * (116.5 + 52.5 * this.GetRashodVodi() * this.PlotnostOroshGidkosti / (num1 * 1000.0));
        }

        public double GetDiametr()
        {
            double num1;
            if (this.Tiprascheta == 0)
            {
                num1 = Math.Pow(4.0 * this.GetObjemScrubbera() / (5.0 * Math.PI / 2.0), 1.0 / 3.0);
            }
            else
            {
                double num2 = Math.PI * this.ScorostGazaVihod;
                if (num2 == 0.0)
                    throw new ArgumentException("Ошибка расчета диаметра через скорость");
                double d = 4.0 * this.GetObjemRashod() / num2;
                num1 = d >= 0.0 ? Math.Sqrt(d) : throw new ArgumentException("Ошибка расчета диаметра через скорость");
            }
            return num1;
        }

        public double GetScorost()
        {
            if (this.GetDiametr() == 0.0)
                throw new ArgumentException("Ошибка расчета скорости");
            return this.Tiprascheta != 0 ? this.ScorostGazaVihod : 4.0 * this.GetObjemRashod() / (Math.PI * Math.Pow(this.GetDiametr(), 2.0));
        }

        public double GetVisotaScrubber()
        {
            if (Math.PI * this.GetDiametr() == 0.0)
                throw new ArgumentException("Ошибка расчета высоты скруббера");
            return 4.0 * this.GetObjemScrubbera() / (Math.PI * Math.Pow(this.GetDiametr(), 2.0));
        }

        public double GetRasstPervRjada() => 0.5 * this.GetDiametr();

        public double GetRasstMuRjadami() => 2.0 * this.GetDiametr();

        public double GetChisloForsunok() => 1.0 + (this.GetVisotaScrubber() - this.GetRasstPervRjada()) / this.GetRasstMuRjadami();

        public double GetScorostDvigKapel() => 0.255 * Math.Pow(this.DiametrKapel, 0.431);

        public double GetStepOchistEnerg()
        {
            this.SoprotScrub = this.TipScrubbera != 0 ? 1.2 : 0.24;
            if (this.GetObjemRashod() == 0.0)
                throw new ArgumentException("Ошибка расчета сетпени очистки энергетической");
            return 1.0 - Math.Exp(-this.KoefB * Math.Pow(this.SoprotScrub + this.DavlenieVodi * this.GetRashodVodi() / this.GetObjemRashod(), this.KoefE));
        }

        public double GetPloschOroshenia()
        {
            if (this.GetObjemRashod() == 0.0)
                throw new ArgumentException("Ошибка расчета площади орошения");
            return this.GetRashodVodi() / this.GetObjemRashod();
        }

        public double GetStepOchistRasch()
        {
            this.Keningem = this.SrednMedRazmer >= 10.0 ? 1.0 : 1.526 * Math.Pow(this.SrednMedRazmer, -0.0644);
            double Wprotiv = this.TipScrubbera != 0 ? this.GetScorost() : this.GetScorostDvigKapel() + this.GetScorost();

            double rez = 18.0 * this.DinamVjazkostGaza * this.DiametrKapel;
            if (rez == 0.0)
                throw new ArgumentException("Ошибка расчета степени очистки расчетная");

            double chStoksa = Math.Pow(this.SrednMedRazmer, 2.0) * this.PlotnostPili * Wprotiv * this.Keningem / rez;

            double kZahCh;
            if (this.GetPloschOroshenia() < 2.0)
                kZahCh = chStoksa != -0.35 ? Math.Pow(chStoksa / (0.35 + chStoksa), 2.0) : throw new ArgumentException("Ошибка расчета степени очистки расчетной");
            else
                kZahCh = 1.0 - 0.15 * Math.Pow(chStoksa, -1.24);

            double result;
            if (this.TipScrubbera == 0)
            {
                double num = 2.0 * this.GetObjemRashod() * this.DiametrKapel * this.GetScorostDvigKapel();
                if (num == 0.0)
                    throw new ArgumentException("Ошибка расчета степени очистки расчетной");
                result = 1.0 - Math.Exp(-3.0 * this.GetRashodVodi() * kZahCh * Wprotiv * this.GetVisotaScrubber() / num);
            }
            else
            {
                double num = 2.0 * this.GetObjemRashod() * this.DiametrKapel;
                if (num == 0.0)
                    throw new ArgumentException("Ошибка расчета степени очистки расчетной");
                result = 1.0 - Math.Exp(-3.0 * this.GetRashodVodi() * kZahCh * this.GetVisotaScrubber() / num);
            }
            return result;
        }
    }
}
