using System;

namespace Classy
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal1 = new Animal("dog","cat");

            var animal2 = new Animal("name", "breed");

            var dog1 = new Dog("max", "bulldog");

            var cat1 = new Cat("sassy");
            bool toes = true;
        }
    }

    class Animal
    {
        public Animal(string name, string breed)
        {

        }
    }

    class Dog :Animal
    {
        public string _name { get; set; }
        public string _breed { get; set; }
        public Animal(string name, string breed)
        {
            _name = name;
            _breed = breed;
        }
        public void Speak(string words)
        {
            Console.WriteLine("My name is Max{0}", _name);
            Console.WriteLine("My breed is Bulldog{0}", _breed);
            Console.WriteLine(words);
        }

    }

    class Cat : Animal
    {
        public string _name { get; set; }
        public bool Toes()
        {
            foreach (bool i in Toes)
            {
                if (i = 6)
                {
                    Console.WriteLine("i is six toes");
                }if (i = 3)
                {
                    Console.WriteLine("does not have six toes");
                }
            }

        }
        
    }
}
