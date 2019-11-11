using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Environment.CurrentDirectory;
            var readFile = File.OpenRead($"{path}/StudentList.txt");
            var reader = new StreamReader(readFile);
            var serializedList = reader.ReadToEnd();

            StudentList studList;
            if (serializedList != "")
            {
                studList = JsonSerializer.Deserialize<StudentList>(serializedList);
            }
            else
            {
                studList = new StudentList
                {
                    _students = new List<Student>
                    {
                        new Student { _p = "BBB", _i = "QQQ", _b = "YYY", _groupId = 1 },
                        new Student { _p = "EEE", _i = "VVV", _b = "MMM", _groupId = 2 },
                        new Student { _p = "FFF", _i = "AAA", _b = "RRR", _groupId = 2 },
                        new Student { _p = "JJJ", _i = "VVV", _b = "YYY", _groupId = 3 },
                        new Student { _p = "NNN", _i = "QQQ", _b = "PPP", _groupId = 3 },
                        new Student { _p = "BBB", _i = "DDD", _b = "CCC", _groupId = 1 }
                    }
                };
            }
            reader.Close();
            studList.ShowList();

            GroupList groupList = new GroupList
            {
                _groups = new List<Group>
                {
                    new Group
                    {
                        _groupName = "First",
                        _id = 1
                    },
                    new Group
                    {
                        _groupName = "Second",
                        _id = 2
                    },
                    new Group
                    {
                        _groupName = "Third",
                        _id = 3
                    }
                }
            };

            //var fq = from iter in groupList._groups
            //         where iter._groupName == "Second"
            //         select iter;

            var ffq = groupList._groups.Where(iter => iter._groupName == "Second").Join(studList._students, 
                n => n._id, 
                k => k._groupId,
                (nn,kk) => new { _groupName = nn._groupName, _p = kk._p, _i = kk._i, _b = kk._b, _groupid = kk._groupId});

            //var ffq = from iter in studList._students
            //          join it in fq on iter._groupId equals it._id
            //          select new { _p = iter._p, _i = iter._i, _b = iter._b, _groupId = iter._groupId };
                        
            Console.WriteLine("");
            foreach (var iter in ffq)
            {
                Console.WriteLine(iter);
            }

            //var fq1 = from iter in studList._students
            //         where iter._p.Contains('B')
            //         orderby iter._i
            //         select iter;

            //Console.WriteLine("");
            //foreach (var iter in fq1)
            //{
            //    Console.WriteLine(iter);
            //}

            //var fq2 = studList._students.OrderBy(n => n._i);

            //Console.WriteLine("");
            //foreach (var iter in fq2)
            //{
            //    Console.WriteLine(iter);
            //}

            serializedList = JsonSerializer.Serialize<StudentList>(studList);

            var writeFile = File.Create($"{path}/StudentList.txt");
            var writer = new StreamWriter(writeFile);
            writer.WriteLine(serializedList);

            writer.Close();
        }
    }
}
