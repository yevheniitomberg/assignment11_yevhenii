using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment11_yevhenii
{
    internal class Pet
    {
        private string name { get; set; }
        private int age { get; set; }
        private PetType type { get; set; }

        public Pet(string name, int age, PetType type)
        {
            this.name = name;
            this.age = age;
            this.type = type;
        }

        public override string ToString()
        {
            return "Pet[name=" + name + ", age=" + age + ", type=" + type + "]";
        }

    }
}
