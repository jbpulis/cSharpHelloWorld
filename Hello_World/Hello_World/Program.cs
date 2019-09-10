using System;

namespace Hello_World
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter your name: ");

            String name = Console.ReadLine();

            Console.WriteLine("Hello " + name +"!");
            //Console.ReadKey(); //not needed on macOS but is required on Windows
        }
    }
}
