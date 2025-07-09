using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace replicando_sintaxe_basica.Models
{
    public class Person
    {//start class
        public string Name { get; set; }//Get: retrieves the Name value; Set: assigns a value to Name
        public int Age { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Hello, my name is {Name} and i have {Age} years old");
        }

    }//End class
}