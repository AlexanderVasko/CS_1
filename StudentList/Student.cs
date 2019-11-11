using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    public class Student
    {
        public string _p { get; set; }
        public string _i { get; set; }
        public string _b { get; set; }
        public int _groupId { get; set; }
        public void Print()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"PIB: {_p} {_i} {_b}\n";
        }
    }
}
