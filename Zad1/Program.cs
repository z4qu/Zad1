/*
1. Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane które chcesz przetrzymywać to:
a. Imię,
b. Nazwisko
c. Wiek
d. Płeć (‘m’ albo ‘k’)
e. PESEL
f. Numer pracownika (np. 2509324094)
Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje
*/

using System;

namespace Homework1
{
    class Program
    {
    static void Main(string[] args)
        {
            //a. Name
            string name;
            
            //b. Surname 
            string surname;
            
            //c. Age
            string age;
            
            //d. Sex (‘m’ or ‘k’)
            string sex;
            
            //e. PESEL 
            string pesel;
            
            //f. Number of employee  (np. 2509324094)
            string numberOfEmployee;
            
            Console.WriteLine("Please provide following data:");
            
            Console.WriteLine("1. Name");

            name = Console.ReadLine();
            
            Console.WriteLine("2. Surname");
            
            surname = Console.ReadLine();
            
            Console.WriteLine("3. Sex ‘m’ or ‘k’");

            sex = Console.ReadLine();
            
            Console.WriteLine("4. Age");
            
            age = Console.ReadLine();
            
            Console.WriteLine("5. PESEL");
            
            pesel = Console.ReadLine();
            
            Console.WriteLine("6. Number of employee");
            
            numberOfEmployee = Console.ReadLine();
            
        }
    }

}

