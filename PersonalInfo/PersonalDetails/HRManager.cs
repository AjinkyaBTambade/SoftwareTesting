using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDetails
{
    public class HRManager
    {
        public HRManager() { }
        public static List<Person> GetPeople() {
            List<Person> people = new List<Person>();
            people.Add(new Person {Name= "Shridhar", Age=28  });
            people.Add(new Person { Name = "Akash", Age = 24 });
            people.Add(new Person { Name = "Bhupendra", Age = 25 });
            people.Add(new Person { Name = "Pragati", Age = 23 });
            people.Add(new Person { Name = "Nayan", Age = 24 });
            people.Add(new Person { Name = "Ajinkya", Age = 22 });
            return people;
        }
    }
}

