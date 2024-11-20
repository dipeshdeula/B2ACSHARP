using fullStackOops.Inheritance;
using fullStackOops.OperatorOverloading;
using fullStackOops.PartialClassMethod;

namespace fullStackOops
{
    internal class Program
    {
        

            /* static async Task Main(string[] args)
             
             {
              */   //Create an object of Car
            /*ClassObjects.Car myCar = new ClassObjects.Car();
             myCar.Make = "Toyota";
             myCar.Model = "Camry";
             myCar.DisplayInfo();

             //create another object of Car
             ClassObjects.Car myCar2 = new ClassObjects.Car();
             myCar2.Make = "Honda";
             myCar2.Model = "Accord";
             myCar2.DisplayInfo();
 */

            //Inheritance
            //Create an object of Animal Class
            /* Inheritance.Animal myAnimal = new Inheritance.Animal("Zebra", "Black and White");
             myAnimal.DisplayInfo();
             myAnimal.Eat();

             //Create an object of Dog Class
             Inheritance.Dog myAnimalDog = new Inheritance.Dog("Bulldog", "Brown", 5);
             myAnimalDog.DogInfo();
             myAnimalDog.Bark();
             myAnimalDog.Eat();

 */

            //polymorphim Method Overriding
            //Create an object of Animal Class
            /*     Polymorphism.MethodOverriding.Animal myAnimal = new Polymorphism.MethodOverriding.Animal("Zebra", "Black and White");
                 myAnimal.DisplayInfo();
                 myAnimal.Eat();

                 //Create an object of Donkey Class
                 Polymorphism.MethodOverriding.Donkey myDonkey = new Polymorphism.MethodOverriding.Donkey("Donkey", "Grey", 100);
                 myDonkey.DonkeyInfo();
                 myDonkey.Eat();

                 //Create an object of Tiger Class
                 Polymorphism.MethodOverriding.Tiger myTiger = new Polymorphism.MethodOverriding.Tiger("Tiger", "Yellow", 10);
                 myTiger.TigerInfo();
                 myTiger.Eat();*/



            //Polymorphism Method Overloading
            //Create an object of MathOperations Class
            /* Polymorphism.MethodOverloading.MathOperations math = new Polymorphism.MethodOverloading.MathOperations();
             Console.WriteLine("Method Overloading Example:");
             Console.WriteLine(math.Add(10));
             Console.WriteLine(math.Add(10, 20));
             Console.WriteLine(math.Add(10, 20, 30));
             Console.WriteLine(math.Add(10, 20.5));*/

            //Abstract

            //Create an object of Saving Class
            /* Abstract.SavingAccount mySaving = new Abstract.SavingAccount();
             mySaving.GetMessage();
             mySaving.Balance();
             mySaving.Deposit();
             mySaving.Withdraw();*/

            //Interface
            //Create an object of Saving Class
            /*Interfaces.SavingAccount mySaving = new Interfaces.SavingAccount();
            mySaving.balance();
            mySaving.closeAccount();
            mySaving.deposit();
            mySaving.openAccount();
            mySaving.withdraw();*/

            //create instances of classes implementing the interface
            /*  Interfaces.IAnimal myDog = new Interfaces.Dog("Spike");
              Interfaces.IAnimal myCat = new Interfaces.Cat("Tom");

              //call the method defined in the interface
              myDog.MakeSound();
              Console.WriteLine($"The dog's name is {myDog.Name}");
              myCat.MakeSound();
              Console.WriteLine($"The cat's name is {myCat.Name}");

              //create instances of classes implementing multiple interfaces
              Interfaces.Robot myRobot = new Interfaces.Robot();
              myRobot.Move();
              myRobot.Read();

  */

            //Encapuslation
            //Create an object of BankAccount Class
            /*     Encapsulations.BankAccount myBankAccount = new Encapsulations.BankAccount();
                 myBankAccount.Deposit(1000);
                 Console.WriteLine(myBankAccount.GetBalance());*/

            //static class
            /*Console.WriteLine("Static Class Example:");
            Console.WriteLine(StaticClass.Calculator.Sum(1, 2));

            StaticClass.Calculator.Store(5);*/

            //constuctors

            /*Constructors.DemoConstrcutor2 demoConstrcutor2 = new Constructors.DemoConstrcutor2();
            demoConstrcutor2.CreateDemoConstructor();*/

            //Destructor
            /* Destructor.MyClass? myClass = new Destructor.MyClass();
             myClass.DoWork();

             //force garbage collection to see destructor in action
             myClass = null;
             GC.Collect();
             GC.WaitForPendingFinalizers();

             Console.WriteLine("End of the program");*/

            //Destructor IDisposable

            /*using (Destructor.MyResource myResourceDes = new Destructor.MyResource())
            {
                //use the resource
                Console.WriteLine("using the resource..");
            }
            //resource.Dispose() is automatically called here

            //Optionally force garbage collection to see the destructor in action 
            GC.Collect();
            GC.WaitForPendingFinalizers();           
*/

            //static class : configuration management (AppSettings)
            /*Console.WriteLine("Configuration management");
            Console.WriteLine(StaticClass.AppSettings.APIBaseURL);
            Console.WriteLine(StaticClass.AppSettings.ConnectionString);*/

            //Utility Methods (StringUtils)
            /*Console.WriteLine("Utility Methods");
            Console.WriteLine(StaticClass.StringUtils.ToTitleCase("hello world"));*/

            //centralizing logging functionlatiy (Logger)
            /*Console.WriteLine("Centralizing logging functionality");
            Console.WriteLine(StaticClass.Logger.Log);*/

            // Caching: Static Data Storage
            /* Console.WriteLine("Caching: Static Data Storage");
             StaticClass.Cache.Add("key1", "value1");
             StaticClass.Cache.Add("key2", "value2");
             Console.WriteLine(StaticClass.Cache.Get("key1"));
             Console.WriteLine(StaticClass.Cache.Get("key2"));

             // ApiHelper: Helper Methods for API Requests
             Console.WriteLine("ApiHelper: Helper Methods for API Requests");
             string apiResponse = await StaticClass.APIHelper.GetApiResponseAsync("https://jsonplaceholder.typicode.com/posts/1");
             Console.WriteLine(apiResponse);
 */
            /*
                        OperatorOverloading.Price p = new OperatorOverloading.Price(12, 0);
                        Console.WriteLine(p);

                        OperatorOverloading.Price q = new OperatorOverloading.Price(4,0);
                        Console.WriteLine(q);

                        Price r = p + q;
                        Console.WriteLine(r);

                        r++;
                        Console.WriteLine(r);

                        if (p > q)
                            Console.WriteLine("p is greater");
                        else
                            Console.WriteLine("Q is greater");*/

            //studentOperator Overloading
            /* OperatorOverloading.StudentOperatorOverloading student1 = new OperatorOverloading.StudentOperatorOverloading("Ram", 20, 1);
             OperatorOverloading.StudentOperatorOverloading student2 = new OperatorOverloading.StudentOperatorOverloading("Shyam", 22, 2);

             Console.WriteLine(student1);
             Console.WriteLine(student2);

             StudentOperatorOverloading student3 = student1 + student2;
             Console.WriteLine(student3);

             student1++;
             Console.WriteLine(student1);*/

            

       /* }*/
    }
}
