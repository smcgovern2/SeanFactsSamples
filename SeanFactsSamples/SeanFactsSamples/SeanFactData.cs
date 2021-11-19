using System;
using System.Collections.Generic;

namespace SeanFactsSamples
{
    public class SeanFactData
    {
        public SeanFactData()
        {
        }
        public static IEnumerable<SeanFactData> All { private set; get; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        public string ImageName { get; set; }
        static SeanFactData()
        {
            List<SeanFactData> all = new List<SeanFactData>();
            all.Add(new SeanFactData() { TheFact = "6\'0\"", ShortFact = "Height", ImageName = "Ruler" });
            all.Add(new SeanFactData() { TheFact = "Too much", ShortFact = "Weight", ImageName = "Scale" });
            all.Add(new SeanFactData() { TheFact = "05/13/1996", ShortFact = "DOB", ImageName="BirthdayHat" });
            all.Add(new SeanFactData() { TheFact = "Green I guess", ShortFact = "Favorite Color", ImageName="GreenDot" });
            all.Add(new SeanFactData() { TheFact = "Dog named Chuck, This isnt him but he looks a lot like this:", ShortFact = "Pets?",ImageName ="SurrogateChuck"});            All = all;

        }
    }
}