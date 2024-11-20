using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.OperatorOverloading
{
    public class StudentOperatorOverloading
    {
        //unary and binary relationship of student class with attribute of : name, age, rolls
        //another question kun kun operator lai overload garna sakindaina

        //fields
        public string Name;
        public int Age;
        public int Rolls;

        //construcotr
        public StudentOperatorOverloading(string name, int age, int rolls)
        {
            Name = name;
            Age = age;
            Rolls = rolls;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Age: " + Age + " Rolls: " + Rolls;
        }


        //unary OperatorOverloading
        public static StudentOperatorOverloading operator ++(StudentOperatorOverloading student)
        {
            student.Rolls++;
            return student;
        }

        //binary OperatorOverloading
        public static StudentOperatorOverloading operator + (StudentOperatorOverloading student1, StudentOperatorOverloading student2)
        {
            int rolls = student1.Rolls + student2.Rolls;
            int age = student1.Age + student2.Age;
            return new StudentOperatorOverloading(student1.Name + student2.Name, age, rolls);
          
        }

       
       
    }
}
