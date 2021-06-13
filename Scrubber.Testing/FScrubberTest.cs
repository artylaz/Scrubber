using NUnit.Framework;
using Scrubber.MatLibrary;

namespace Scrubber.Testing
{

    public class FScrubberTest
    {
        public FScrubber cVhodScrubber = new FScrubber();
        public FScrubberTest()
        {
            //Исходные данные

            cVhodScrubber.Tiprascheta = 0;
            cVhodScrubber.BarDavlenie = 101.0;
            cVhodScrubber.IzbitDavlenie = 12.0;
            cVhodScrubber.Rashod = 18.0;
            cVhodScrubber.TemperaturaGazaVhod = 144.0;
            cVhodScrubber.TemperaturaGazaVihod = 49.0;
            cVhodScrubber.TeploemkGazaVhod = 0.87;
            cVhodScrubber.TeploemkGazaVihod = 0.82;
            cVhodScrubber.NachVlagosod = 0.018;
            cVhodScrubber.PlotnostSuhGaz = 0.95;
            cVhodScrubber.PlotnostOroshGidkosti = 1000.0;
            cVhodScrubber.DinamVjazkostGaza = 2.2E-05;
            cVhodScrubber.TemperVodiVhod = 21.0;
            cVhodScrubber.TeploemkVodi1 = 4.182;
            cVhodScrubber.TeploemkVodi2 = 4.182;
            cVhodScrubber.Poteri = 10;
            cVhodScrubber.TeploemkPara = 2.09;
            cVhodScrubber.KoefIsparenia = 0.5;
            cVhodScrubber.DavlenieVodi = 290.0;
            cVhodScrubber.DiametrKapel = 0.0008;
            cVhodScrubber.SrednMedRazmer = 3E-05;
            cVhodScrubber.PlotnostPili = 2000.0;
            cVhodScrubber.ScorostGazaVihod = 1.8;
            cVhodScrubber.KoefB = 0.0988;
            cVhodScrubber.KoefE = 0.4663;
        }

        

        [Test]
        public void GetKolTeplaTest()
        {
            var expected = 1447.3898;
;

            Assert.AreEqual(cVhodScrubber.GetKolTepla(), expected, 4);
        }

        [Test]
        public void GetRashodVodiTest()
        {
            var expected = 13.627;

            Assert.AreEqual(cVhodScrubber.GetRashodVodi(), expected, 3);
        }

        [Test]
        public void GetVlagosodergKonechTest()
        {
            var expected = 0.396532146;

            Assert.AreEqual(cVhodScrubber.GetVlagosodergKonech(), expected, 3);
        }

        [Test]
        public void GetObjemRashodTest()
        {
            var expected = 28.41937197;

            Assert.AreEqual(cVhodScrubber.GetObjemRashod(), expected, 3);
        }

        [Test]
        public void GetObjemScrubberaTest()
        {
            var expected = 173.6173577;

            Assert.AreEqual(cVhodScrubber.GetObjemScrubbera(), expected, 3);
        }

        [Test]
        public void GetDiametrTest()
        {
            var expected = 4.455068822;

            Assert.AreEqual(cVhodScrubber.GetDiametr(), expected, 3);
        }

        [Test]
        public void GetScorostTest()
        {
            var expected = 1.823122119;

            Assert.AreEqual(cVhodScrubber.GetScorost(), expected, 3);
        }

        [Test]
        public void GetVisotaScrubberTest()
        {
            var expected = 11.13767206;

            Assert.AreEqual(cVhodScrubber.GetVisotaScrubber(), expected, 3);
        }

        [Test]
        public void GetStepOchistEnergTest()
        {
            var expected = 0.627440684;

            Assert.AreEqual(cVhodScrubber.GetStepOchistEnerg(), expected, 3);
        }

        [Test]
        public void GetPloschOrosheniaTest()
        {
            var expected = 0.479502407;

            Assert.AreEqual(cVhodScrubber.GetPloschOroshenia(), expected, 3);
        }

        [Test]
        public void GetStepOchistRaschTest()
        {
            var expected = 1;

            Assert.AreEqual(cVhodScrubber.GetStepOchistRasch(), expected, 3);
        }

        [Test]
        public void GetScorostDvigKapelTest()
        {
            var expected = 0.01179701;

            Assert.AreEqual(cVhodScrubber.GetScorostDvigKapel(), expected, 3);
        }

        [Test]
        public void GetTemperVodiVihodTest()
        {
            var expected = 61.87360599;

            Assert.AreEqual(cVhodScrubber.GetTemperVodiVihod(), expected, 3);
        }

        [Test]
        public void GetTeplosodGazaVhodTest()
        {
            var expected = 128.6316;

            Assert.AreEqual(cVhodScrubber.GetTeplosodGazaVhod(), expected, 3);
        }

        [Test]
        public void GetTeplosodGazaVihodTest()
        {
            var expected = 40.18;

            Assert.AreEqual(cVhodScrubber.GetTeplosodGazaVihod(), expected, 3);
        }


        [Test]
        public void RaschetTest()
        {

            // Должно получиться

            double EqlDiam = 4.484;
            double Visota = 11.138;
            double RastOs = 2.228;
            double RastRyad = 8.910;
            double EnerKof = 0.62744;
            double PlotOr = 0.480;
            double StepOch = 1;
            double ChRyadFur = 2;
            double SkorGaza = 1.823;

            Assert.AreEqual(cVhodScrubber.GetDiametr(), EqlDiam, 3);
            Assert.AreEqual(cVhodScrubber.GetVisotaScrubber(), Visota, 3);
            Assert.AreEqual(cVhodScrubber.GetRasstPervRjada(), RastOs, 3);
            Assert.AreEqual(cVhodScrubber.GetRasstMuRjadami(), RastRyad,3);
            Assert.AreEqual(cVhodScrubber.GetStepOchistEnerg(), EnerKof,5);
            Assert.AreEqual(cVhodScrubber.GetPloschOroshenia(),  PlotOr,3);
            Assert.AreEqual(cVhodScrubber.GetStepOchistRasch(), StepOch,5);
            Assert.AreEqual(cVhodScrubber.GetChisloForsunok(), ChRyadFur,0);
            Assert.AreEqual(cVhodScrubber.GetScorost(), SkorGaza,3);
        }

    }
}