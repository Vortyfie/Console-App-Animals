using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Animals
{
    internal class Animal
    {
            public string Name;

            public Animal(string name)
            {
                this.Name = name;
            }

        public Animal()
        {
            this.Name = "coco";
        }

        public void Move()
            {
                Console.WriteLine($"Le {Name} fait sont sport.");
            }

            public void Sleep()
            {
                Console.WriteLine($"Le {Name} fait un petit dodo.");
            }
        }
    }