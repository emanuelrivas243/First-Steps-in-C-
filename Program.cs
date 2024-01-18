// See https://aka.ms/new-console-template for more information

using System;

namespace CSharpHelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            // 
            Console.WriteLine("Hello C#");
            string myString = "Silent Hill";
            Console.WriteLine(myString);
            
            int myInt = 243;
            var myArray = new string[] {"Silent Hill 2", "Zelda Twilight Princess", "Silent Hill 3"};
            foreach (string games in myArray) 
            {
                Console.WriteLine($"Game: {games}");
            }

        }
    }
}

