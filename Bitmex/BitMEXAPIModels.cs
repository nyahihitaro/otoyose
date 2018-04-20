using System;
using System.Collections.Generic;
using System.Text;

namespace BitMEX
{
    public class Quote
    {
        public string timestamp = "";
        public string symbol = "";
        public double bidSize = 0;
        public double bidPrice = 0;
        public double askSize = 0;
        public double askPrice = 0;
    }
}