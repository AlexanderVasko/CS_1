using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationXMLJSON
{
    class School
    {
        public string _schoolName { get; set; }
        public string _adress { get; set; }
        public List<Classes> _classes { get; set; }
    }
}
