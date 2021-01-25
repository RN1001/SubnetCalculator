using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SubnetCalculator.Model
{
    class CidrRangeCollections
    {
        public ObservableCollection<string> cidrClassARange = new ObservableCollection<string>()
        {
            new string("8"),
            new string("9"),
            new string("10"),
            new string("11"),
            new string("12"),
            new string("13"),
            new string("14"),
            new string("15"),
            new string("16"),
            new string("17"),
            new string("18"),
            new string("19"),
            new string("20"),
            new string("21"),
            new string("22"),
            new string("23"),
            new string("24"),
            new string("25"),
            new string("26"),
            new string("27"),
            new string("28"),
            new string("29"),
            new string("30"),
        };

        public ObservableCollection<string> cidrClassBRange = new ObservableCollection<string>()
        {
            new string("16"),
            new string("17"),
            new string("18"),
            new string("19"),
            new string("20"),
            new string("21"),
            new string("22"),
            new string("23"),
            new string("24"),
            new string("25"),
            new string("26"),
            new string("27"),
            new string("28"),
            new string("29"),
            new string("30"),
        };

        public ObservableCollection<string> cidrClassCRange = new ObservableCollection<string>()
        {
            new string("24"),
            new string("25"),
            new string("26"),
            new string("27"),
            new string("28"),
            new string("29"),
            new string("30"),
        };
    }
}
