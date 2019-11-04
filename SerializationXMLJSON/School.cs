using System.Collections.Generic;

namespace SerializationXMLJSON
{

    public class School
    { 
        public int _var;
        public string _schoolName { get; set; }
        public string _adress { get; set; }
        public List<Classes> _classes { get; set; }
    }
}
