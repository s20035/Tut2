using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using APBDTUT2.Models;

namespace APBDTUT2
{
    public class Program
    {
       public static void Main(string[] args)
        {
            var path = args[0];
            var listOfStudents = new HashSet<Student>(new CustomComparer());
            var data = new FileInfo(path);
            using var sw = new StreamWriter(@"log.txt");
            using (var stream = new StreamReader(data.OpenRead()))
            {
                string line = null;
                while ((line = stream.ReadLine()) != null)
                {
                    string[] columns = line.Split(',');
                    var name = columns[0];
                    var surname = columns[1];
                    var studentno = "s"+columns[4];
                    var email = columns[6];
                    var date = DateTime.Parse(columns[5]);
                    var maname = columns[7];
                    var paname = columns[8];
                    var exer = new Studies {
                        Sname = columns[2],
                    Smode = columns[3]
                    };
                    var st = new Student
                    {
                        Email = email,
                        FirstName = name,
                        LastName = surname,
                        StudentNo = studentno,
                        Birthdate = date,
                        Mothersname =maname,
                        Fathersname =paname,
                    };
                    if (listOfStudents.Contains(st))
                    {
                        Console.WriteLine("element exists in the set");
                    }
                    if (!listOfStudents.Add(st))
                    {
                        sw.WriteLine($"element with the first name {st.FirstName} was not added to the set");
                    }
                    listOfStudents.Add(st);
                    Console.WriteLine(line);
                }
            }





            Console.WriteLine(listOfStudents.Count);
            
            FileStream writer = new FileStream(args[1]+"\\result."+args[2], FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(HashSet<Student>),
                                                new XmlRootAttribute("university"));
            serializer.Serialize(writer, listOfStudents);
            

        } 
    }
}
