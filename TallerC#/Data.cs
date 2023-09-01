using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerC_
{
    public class Data
    {

        public List<Person> Persons { get; set; }

        public Data()
        {
            Persons = new List<Person>();

        }

        private void CreatePerson()
        {
            Persons.Add(new Person("Juan Perez", "12.345.678-9"));
            Persons.Add(new Person("Maria Gonzalez", "18.456.789-0"));
            Persons.Add(new Person("Pedro Ramirez", "16.345.678-1"));
            Persons.Add(new Person("Miguel de Cervantes", "1.234.423-1"));
            Persons.Add(new Person("Alberto Galindo", "20.255.234-K"));
        }

        public void Poblate()
        {
            CreatePerson();
        }

        public void Show()
        {
            Console.WriteLine("Person list: ");
            
            foreach(var persons in  Persons)
            {
                Console.WriteLine(persons.Name);
            }
        }

    }
}
