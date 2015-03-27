using System;
using System.Collections.Generic;
using System.Text;

namespace SWF_2340_15_8._1
{
    class Report
    {
        public string owner { get; private set; }
        public string item { get; private set; }
        public double price { get; private set; }
        public string location { get; private set; }

        public Report()
        {
            owner = "";
            item = "";
            location = "";
        }

        public Report(String owner, String item, double price, String location)
        {
            this.owner = owner;
            this.item = item;

            this.price = price;
            this.location = location;
        }
    }
}
