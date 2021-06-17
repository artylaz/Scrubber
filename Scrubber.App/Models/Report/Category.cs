using System.Collections.Generic;

namespace Scrubber.App.Models.Report
{
    class Category
    {
        private string FName;
        private string FDescription;
        private List<Result> FResult;

        public string Name
        {
            get { return FName; }
        }

        public string Description
        {
            get { return FDescription; }
        }

        public List<Result> Results
        {
            get { return FResult; }
        }

        public Category(string name, string disrk)
        {
            FName = name;
            FDescription = disrk;
            FResult = new List<Result>();
        }
    }
}
