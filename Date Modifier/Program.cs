using System;
using System.IO;

namespace Date_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();
            var daysDifference = new DateModifier();
            Console.WriteLine(daysDifference.GetsdaysDiference(start,end));
        }
    }
}
