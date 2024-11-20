namespace fullStackOops.Inheritance
{
    //base class : Animal
    public class Animal
    {
        private string Name;
        private string Color;

        //constructor
        public Animal(string name, string color)
        {
            Name = name;
            Color = color;
        }


        //public method
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Color: {0}", Color);
        }

    }

    //derived class : Dog

    public class Dog : Animal
    {
        //dog has own his fields
        private int age;
        //constructor
        public Dog(string name, string color, int age) : base(name, color)
        {
            this.age = age;
        }

        //DogInfo method
        public void DogInfo()
        {
            DisplayInfo();
            Console.WriteLine("Age: {0}", age);
        }

        //derived class method
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }


    
    }
}
