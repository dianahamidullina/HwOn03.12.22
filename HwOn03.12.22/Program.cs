using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HwOn03._12._22
{
    public class Program
    {
       
        static void ReadFile(string path , List<Person> lists)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                
               while (!sr.EndOfStream)
               {
                string[] list = new string[3];
                Person person = new Person();
                string text = sr.ReadLine();
                list = text.Split(' ');
                person.name = list[0];
                person.group = int.Parse(list[1]);
                person.num = int.Parse(list[2]);
                lists.Add(person);
               }
                
            }

        }
        public static void AddToFile(string filename , string text)
        {
         File.AppendAllText(filename, text);
        }
        public static void RemoveFromFile(string s , string txt)
        {
            var tempFile = Path.GetTempFileName();
            var linesToKeep = File.ReadLines(txt).Where(l => l != s);
            File.WriteAllLines(tempFile, linesToKeep);
            File.Delete(txt);
            File.Move(tempFile, txt);
        }

        public static List<double> Probability(List<double> vers)
        {
            double sum = vers.Sum();
            vers[0] /= sum;
            for (int i = 1; i < vers.Count; i++)
            {
                vers[i] = vers[i] / sum + vers[i - 1];
            }
            return vers;
        }

        public static void GetRNDIndex(Random rnd, List<double> vers, int ab)
        {
            
            double rndval = rnd.NextDouble();
            for (int i = 0; i < vers.Count; i++)
            {
                if (vers[i] > rndval)
                {
                    ab = i;

                }
            }
        }

    public static void Task2()
        {
            Interests interests = new Interests();
            Person1 person1 = new Person1();
            interests.Sleeping += person1.PrintMassage;
            Person2 person2 = new Person2();
            interests.Consert += person2.PrintMassage;
            Person3 person3 = new Person3();
            interests.Proga += person3.PrintMassage;
            interests.Massage();
            Console.WriteLine("Print enter if u would like to go out ");




        }



    static void Main(string[] args)
        {
            //1
            string path = @"path.txt";
            Random rnd = new Random();
            List<Person> persons = new List<Person>();
            ReadFile(path, persons);
            List<double> vers = new List<double>();
            foreach (Person p in persons)
            {
                vers.Add(p.num);
            }
            Console.WriteLine("Enter name of the event");
            List <string> events = new List<string>();
            events.Add("New Year");
            events.Add("Christmas");
            events.Add("Frind's day");
            foreach (var r in events)
            {
                Console.WriteLine(r);
            }
            string nameevent= Console.ReadLine();
            Console.WriteLine("Print the date of the event");
            DateTime data;
            while(!DateTime.TryParse(Console.ReadLine(), out data))
            {
                Console.WriteLine("Error.Tru again");
            }
            Console.WriteLine("Enter needed number of people");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Error.Try again");
            }
            Console.WriteLine($"Event {nameevent} \nThe data {data}  \nNumber of group {number}");
            Probability(vers);
            int ind = 0;
            for (int i = 0; i<number; i++)
            {
                Person pers = new Person();
                GetRNDIndex(rnd, vers,ind);
                pers = persons[ind];
                Console.WriteLine($"Person {i}");
                Console.WriteLine($"Name: {pers.name}  \nNumber of group: {pers.group}");
               persons.RemoveAt(ind);
                RemoveFromFile($"{pers.name} {pers.group} {pers.num} ", path);
                AddToFile(path, $"{pers.name} {pers.group} {pers.num += 1}");
            }
            //2

            Task2();
         

        }
     }
}
