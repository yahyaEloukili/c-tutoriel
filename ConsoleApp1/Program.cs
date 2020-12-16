using System;


    class Program
    {
        static void Main(string[] args)
        {
        //Concatenation
            Console.WriteLine("Please enter your name !");
        String username = Console.ReadLine();
        Console.WriteLine("Hello "+username);
        //placeholder syntax - prefered
        Console.WriteLine("Please enter your first name !");
        String firstname = Console.ReadLine();
        Console.WriteLine("Please enter your last name !");
        String lastname = Console.ReadLine();
        Console.WriteLine("Hello {0} {1} ",firstname, lastname);

    }
    }

