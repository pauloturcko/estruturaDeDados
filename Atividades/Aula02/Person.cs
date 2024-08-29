using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula02
{
    public class Person
    {
        public string _location = string.Empty;

        public string Name { get; set; }

        public int Age { get; set; }

        //Método Construtor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person ()
        {
            Name = "";
        }

        // Método para realocar a pessoa | VOID = VAZIO
        public void Realocate(string location)
        {
            if(!string.IsNullOrEmpty(location))
            {
                _location = location; // Questionar o por que do _location, com o underline
            }
        }

        public float GetDistance(string location)
        {
            return 0;
        }
    }
}