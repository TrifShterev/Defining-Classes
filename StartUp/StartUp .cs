using System;
using System.IO;

namespace DefiningClasses
{
  public  class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] newPerson = Console.ReadLine().Split();
                int age = int.Parse(newPerson[1]);

                var newFamilyMember = new Person(newPerson[0], age);
                family.AddMember(newFamilyMember);

            }
            var oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
           
            
        }
    }
}
