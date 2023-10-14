using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name = "Гарри Поттер";
            int age = 17;
            string email = "potter@hogwarts.com";
            int rezultsOfProgramming = 5;
            int rezaltsOfMath = 4;
            int rezaltsOfPhisics = 3;
            double allRezults = ((double)rezultsOfProgramming + (double)rezaltsOfMath + (double)rezaltsOfPhisics) / 3;
            //Console.WriteLine("Ф.И.О. " + name + "\n" + "Возраст " + age + "\n" + "Email " + email + "\n" +
            //    "Баллы по программированию " + rezultsOfProgramming + "\n" + "Баллы по математике " + rezaltsOfMath +
            //    "\n" + "Баллы по физике " + rezaltsOfPhisics);
            //Console.ReadKey();
            //Console.WriteLine("Средний балл " + allRezults);
            //Console.WriteLine($"Ф.И.О. {name} \nВозраст {age} \nEmail {email} \nБаллы по программированию {rezultsOfProgramming} " +
            //   $"\nБаллы по математике {rezaltsOfMath} \nБаллы по физике {rezaltsOfPhisics} \nСредний балл {allRezults}");
            Console.WriteLine("Ф.И.О. " + "\t" + name);
            Console.ReadKey();
            Console.WriteLine("Возраст " + "\t" + age);
            Console.ReadKey();
            Console.WriteLine("Email " + "\t" + email);
            Console.ReadKey();
            Console.WriteLine("Баллы по программированию " + "\t" + rezultsOfProgramming);
            Console.ReadKey();
            Console.WriteLine("Баллы по математике " + "\t\t" + rezaltsOfMath);
            Console.ReadKey(); 
            Console.WriteLine("Баллы по физике " + "\t\t" + rezaltsOfPhisics);
            Console.ReadKey();
            Console.WriteLine("Средний балл " + "\t\t\t" + allRezults);
            Console.ReadKey();
  
        }
    }
    
}