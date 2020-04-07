using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];

        names[0] = "Coraline";
        names[1] = "Jane";
        names[2] = "Sarah";
        names[3] = "Jake";
        names[4] = "Felicity";

        foreach(string s in names)
        Console.WriteLine("Hello " + s);
    

        Console.ReadLine();
        }
    }
}
