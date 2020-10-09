using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DefiningClasses
{
  public  class Family
    {
        public Family()
        {
            this.FamilyMembers = new List<Person>();
        }
        public List<Person> FamilyMembers { get;set; }

        public void AddMember(Person member) {
            

            FamilyMembers.Add(member);
            
        }
        public Person GetOldestMember()

        {

            var oldestPerson = FamilyMembers.OrderByDescending(x=>x.Age).FirstOrDefault();

            return oldestPerson;

        }
        public List<Person> GetPersonsOver30()
        {
          var oldestPersons = FamilyMembers.OrderBy(x => x.Name).Where(x => x.Age > 30).ToList();
            return oldestPersons;
        }
    }
}
