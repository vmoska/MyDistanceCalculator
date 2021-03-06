using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDistanceCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Welcome();
            Person[] persons = RequestPersonalData();

            foreach (Person item in persons)
            {
               ShowDistanceFromOthers(item, persons);

            }


            Console.ReadKey();
        }

        private static void ShowDistanceFromOthers(Person person, Person[] persons)
        {
            Console.WriteLine($"Let's calculate the distance {person.Name} from others");
            Console.WriteLine("------------------------------------");
            foreach (Person item in persons)
            {

                if (item != person)
                {

                    ShowDistance(person, item);
                }

            }


        }

        private static void ShowDistance(Person person, Person item)
        {

            Console.WriteLine($"The distance {item.Name} is : {person.CalcDistance(item).ToString()}");
        }

        private static Person[] RequestPersonalData()
        {
            Console.WriteLine("Enter the data of the people whose distance you want to calculate");
            List<Person> persons = new List<Person>();
            bool keepon = true;
            while (keepon)
            {
                string nome = RequestName();
                double coordinataX = RequestCoordinated("X");
                double coordinataY = RequestCoordinated("Y");

                Person p = new Person();
                p.Name = nome;
                p.CoordinatedX = coordinataX;
                p.CoordinatedY = coordinataY;
                persons.Add(p);

                bool continueWithOthersPersons = RequestContinue();
                if (!continueWithOthersPersons)
                    keepon = false;

            }
            return persons.ToArray();

        }

        private static bool RequestContinue()
        {
            Console.WriteLine("If you are done press c");
            string t = Console.ReadLine();

            if (t == "c")
                return false;

            return true;
        }

        private static double RequestCoordinated(string nameCoordinated)
        {
            Console.WriteLine("Enter the coordinated " + nameCoordinated + " of the person");
            double coordinated = 0;
            bool keepon = true;
            while (keepon)
            {
                string cx = Console.ReadLine();

                try
                {
                    coordinated = double.Parse(cx);
                    keepon = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Coordinated " + nameCoordinated + " not correct, retype the coordinated");
                }
            }
            return coordinated;
        }



        private static string RequestName()
        {
            Console.WriteLine("Enter the name");
            string name = "";
            bool keepon = true;
            while (keepon)
            {
                name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                    keepon = false;
                else
                {
                    Console.WriteLine("Name not correct, retype the name");
                }
            }
            return name;
        }

        private static void Welcome()
        {
            Console.WriteLine("Welcome!");
        }
    }
}
    

