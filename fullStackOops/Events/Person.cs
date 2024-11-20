using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Events
{
    public class Person
    {
        string name;
        int age;

        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;

        }

        public int Age
        {
            get => age;

            set
            {

                if (age == value) return; // Exit if nothing has changed
                
                int oldAge = age;
                age = value;

                if (age > 18)
                { 
                    OnAgeChanged(new AgeChangedEventArgs(oldAge,age));
                }


                
            }
        }

        // Declare the event using EventHandler<T>
        public event EventHandler<AgeChangedEventArgs> AgeChanged;

        // Method to raise the event
        protected virtual void OnAgeChanged(AgeChangedEventArgs e)
        {
            AgeChanged?.Invoke(this, e);
        }



    }
}
