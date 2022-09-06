using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCDMapper.Classes
{
    public class Binding
    {
        public string title { get; set; }
        public string partNumber { get; set; }
        public string groupp { get; set; }
        public string configuration { get; set; }
        public string phase { get; set; }
        public Binding()
        {

        }

        override
        public string ToString() {
            return title + " - " + partNumber + " | Mapping: " + groupp + "." + configuration + "." + phase;
        }

    }
}
