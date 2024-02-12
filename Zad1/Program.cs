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
using System.Runtime;
    
    
namespace Homework1
{
    class Program
    {
    static void Main(string[] args)
        {
            //a. Name
            Console.WriteLine("Please provide following data:");
            Console.WriteLine("1. Name");
            var name = Console.ReadLine();
            
            //b. Surname 
            Console.WriteLine("2. Surname");
            var surname = Console.ReadLine();
            
            //c. Age
            Console.WriteLine("3. Age");
            int.TryParse(Console.ReadLine(), out var age);
            
            //d. Gender (‘m’ or ‘k’)
            Console.WriteLine("4. Gender ‘m’ or ‘k’");
            string gender = Console.ReadLine();
            
            //e. PESEL 
            Console.WriteLine("5. PESEL");
            long.TryParse(Console.ReadLine(), out var pesel);
            
            //f. Number of employee  (np. 2509324094)
            Console.WriteLine("4. Number of employee");
            int.TryParse(Console.ReadLine(), out var numberOfEmployee);
            numberOfEmployee.ToString()
           
            Console.Write($"1. {name} \r\n2. {surname} \r\n3. {age} \r\n4. {gender[0]} \r\n5. {pesel} \r\n6. {numberOfEmployee}");
            
        }
    }

}

