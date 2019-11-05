using System;
using System.Collections.Generic;
using System.Text;

namespace StudentList
{
    public class StudentList
    {
        public List<Student> _students { get; set; }
        public void ShowList()
        {
            foreach (var iter in _students)
            {
                iter.Print();
            }
        }
    }
}
