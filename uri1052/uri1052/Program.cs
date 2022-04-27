using System;

namespace uri1052
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] month = {"January",
                              "February", 
                              "March", 
                              "April", 
                              "May", 
                              "June", 
                              "July", 
                              "August", 
                              "September", 
                              "October", 
                              "November", 
                              "December"};

            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(month[number -1]);
        }
    }
}
