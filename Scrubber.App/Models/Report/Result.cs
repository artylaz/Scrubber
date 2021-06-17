namespace Scrubber.App.Models.Report
{
    class Result
    {
        public string Name { get; set; }

        public double? UnitResult { get; set; }

        public Result(string name, double? unitResult)
        {
            Name = name;
            UnitResult = unitResult;
        }

        public Result(){}
    }
}
