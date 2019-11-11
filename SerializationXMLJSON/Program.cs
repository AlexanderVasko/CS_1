using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
//using System.Xml.Serialization;

namespace SerializationXMLJSON
{
    class Program
    {        
        static void Main(string[] args)
        {
            //var step = new School
            //{
            //    _adress = "alalal 123",
            //    _schoolName = "STEP",
            //    _classes = new List<Classes> {
            //        new Classes {
            //            _number = 10,
            //            _pupils = new List<Pupil> {
            //                 new Pupil {_name = "Ivan" },
            //                 new Pupil {_name = "Petro" },
            //                 new Pupil {_name = "Pavlo" },
            //                 new Pupil {_name = "Igor" }
            //            }
            //        },
            //        new Classes                    {
            //            _number = 5,
            //            _pupils = new List<Pupil> {
            //                new Pupil {_name = "Ivan" },
            //                new Pupil {_name = "Petro" },
            //                new Pupil {_name = "Pavlo" },
            //                new Pupil {_name = "Igor" }
            //            }
            //        },
            //        new Classes                    {
            //           _number = 10,
            //           _pupils = new List<Pupil> {
            //               new Pupil {_name = "Ivan" },
            //               new Pupil {_name = "Petro" },
            //               new Pupil {_name = "Pavlo" },
            //               new Pupil {_name = "Igor" }
            //           }
            //        }
            //    }
            //};

            Pupil pup1 = new Pupil();
            pup1._name = "ivan";
            Pupil pup2 = new Pupil();
            pup2._name = "ivan2";
            Pupil pup3 = new Pupil();
            pup3._name = "ivan3";
            Pupil pup4 = new Pupil();
            pup4._name = "Petya1";
            Pupil pup5 = new Pupil();
            pup5._name = "Petya2";
            Pupil pup6 = new Pupil();
            pup6._name = "Petya3";

            Classes aClass = new Classes();
            aClass._number = 1;
            aClass._pupils = new List<Pupil>();
            aClass._pupils.Add(pup1);
            aClass._pupils.Add(pup2);
            aClass._pupils.Add(pup3);

            Classes bClass = new Classes();
            bClass._number = 2;
            bClass._pupils = new List<Pupil>();
            bClass._pupils.Add(pup4);
            bClass._pupils.Add(pup5);
            bClass._pupils.Add(pup6);

            School step = new School();
            step._adress = "lalala 141";
            step._schoolName = "STEP";
            step._classes = new List<Classes>();
            step._classes.Add(aClass);
            step._classes.Add(bClass);

            var serializedJSON = JsonSerializer.Serialize(step);
            var deserializedJSON = JsonSerializer.Deserialize<School>(serializedJSON);

            //var memStream = new MemoryStream(10000);

            //var serializedXML = new XmlSerializer(typeof(School));

            //serializedXML.Serialize(memStream, step);

            //var byteArray = memStream.ToArray();
            //Console.WriteLine(Encoding.UTF8.GetString(byteArray));
        }
    }
}
