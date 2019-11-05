using System;
using System.Collections.Generic;
using System.Text;

namespace StudentList
{
    public class Group
    {
        public string _groupName;
        public int _id;

        public override string ToString()
        {
            return $"Group name: {_groupName} {base.ToString()}";
        }
    }
}
