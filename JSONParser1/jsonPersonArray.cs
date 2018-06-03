using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONParser1
{
    class jsonPersonArray : jsonPersonComplex
    {
        /*
        public string firstname { get; set; }
        public string lastname { get; set; }
        public double age { get; set; }
        public bool isAlive { get; set; }
        public addr address { get; set; }
        */    
        public List<phoneNum> phoneNumbers { get; set; }

        /*
        public class addr
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string postCode { get; set; }
        }
        */

        public class phoneNum
        {
            public string type { get; set; }
            public string number { get; set; }
        }
    }
}
