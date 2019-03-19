using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;


namespace ConsoleApplication41
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person {FirstName = "Riz", LastName = "Kler", Age = 49},
                new Person {FirstName = "Cindy", LastName = "Crawford", Age = 53},
                new Person {FirstName = "John", LastName = "Doe", Age = 25},
                new Person {FirstName = "Jane", LastName = "Smith", Age = 23},
                new Person {FirstName = "Allen", LastName = "Smith", Age = 23},
                new Person {FirstName = "Payl", LastName = "Smith", Age = 35},
                new Person {FirstName = "Carl", LastName = "Williams", Age = 23},
                new Person {FirstName = "Tony", LastName = "Williams", Age = 23},

            };

            var result = from p in people
                where p.Age > 18
                   orderby p.LastName ascending
                    group p by p.LastName;
         //       select p;

            foreach (var item in result)
            {
                Console.WriteLine(item.Key + " - " + item.Count());
                foreach (var p in item)
                {
                    Console.WriteLine("\t{0}, {1}", p.LastName, p.FirstName);
                }
       //         Console.WriteLine("{0}, {1}", item.FirstName, item.LastName);
            }

         //   Console.ReadLine();
            
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

    }
}


