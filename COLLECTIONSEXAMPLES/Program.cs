using System;
using System.Collections.Generic;

namespace COLLECTIONSEXAMPLES
{
    class Program
    {
        static void Main(string[] args)
        {
            // LIST EXAMPLE


            //var people = new List<string>();

            //people.Add("James");
            //people.Add("Jason");
            //people.Add("Grace");

            //foreach (var person in people)
            //{
            //    Console.WriteLine(person);
            //}

            //people.Remove("James");

            //Console.WriteLine(new string('=', 20));

            //foreach (var person in people)
            //{
            //    Console.WriteLine(person);
            //}


            //people.RemoveAt(people.Count -1);

            //Console.WriteLine(new string('=', 20));

            //foreach (var person in people)
            //{
            //    Console.WriteLine(person);
            //}

            //Console.ReadLine();


            //var person = new Person();
            //person.MakeNoise();



            //var names = new List<string>()
            //{
            //    "James",
            //    "Jason",
            //    "Grace"
            //};

            //while (true)
            //{
            //    foreach (var name in names)
            //    {
            //        Console.WriteLine(name);
            //    }

            //    Console.WriteLine("enter your name, and we will add you to the staff list!");
            //    var userInput = Console.ReadLine();

            //    names.Add(userInput);

            //    Console.Clear();
            //    foreach (var name in names)
            //    {
            //        Console.WriteLine(name);
            //    }

            //    Console.WriteLine("do you want to add another name? press [y/n]");

            //    var userKey = Console.ReadKey();

            //    if (userKey.Key != ConsoleKey.Y)
            //    {
            //        break;
            //    }
            //    Console.Clear();
            //}

            // OOP EXAMPLE,REMEMBER TO F12 INTO THE PERSON CLASS TO SEE THE SEPERATE FILE

            var james = new Person("James");

            james.Name = "Ja";

            Console.WriteLine(james.Name);

            james.Name = "James";

            Console.WriteLine(james.Name);
        }
    }
}
