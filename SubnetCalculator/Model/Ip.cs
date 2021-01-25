using System;
using System.Collections.Generic;
using System.Text;

namespace SubnetCalculator.Model
{
    class Ip
    {
        public int Cidr { get; set; }
        public string Address { get; set; }
        public char SubnetClass { get; set; }
    }
}
