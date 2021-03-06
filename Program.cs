﻿using System;
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
            };

            var result = from p in people
                where p.Age > 25
                //    orderby p.LastName descending
                //    group p by p.LastName;
                select p;

            foreach (var item in result)
            {
                Console.WriteLine("{0}, {1}", item.FirstName, item.LastName);
            }
        }
    }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public int Age { get; set; }

        }
    }

