using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Polymorphism.MethodOverriding
{
    //polymorphism is a method which acts differently based on the object that calls it
    public class Animal
    {
        //fields
        private string Name;
        private string Color;

        //constructor
        public Animal(string name, string color) {
            Name = name;
            Color = color;
        }

        //public method
        public void DisplayInfo() {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Color: {0}", Color);
        }
        //base class ko method lai override garna lai virtual keyword use garne
        public virtual void Eat() {
            Console.WriteLine("Animal is eating");
        }
    }

    public class Donkey : Animal {

        private int weight;
        public Donkey(string name,string color,int weight) : base(name,color)
        {
            this.weight = weight;
        }

        public void DonkeyInfo() {
            DisplayInfo();
            Console.WriteLine("Weight: {0}", weight);
        }

        public override void Eat()
        { 
           Console.WriteLine("Donkey is eating grass");
        }
    }

    public class Tiger : Animal{ 
        private int age;
        public Tiger(string name, string color, int age) : base(name, color)
        { 
            this.age = age;
        }

        public void TigerInfo()
        {
            DisplayInfo();
            Console.WriteLine("Age: {0}", age);
        }

        public override void Eat()
        {
            Console.WriteLine("Tiger is eating flesh");
        }
    }
}
